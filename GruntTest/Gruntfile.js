module.exports = function (grunt) {
    'use strict';
    // Time how long tasks take. Can help when optimizing build times
    require('time-grunt')(grunt);
    // Project configuration
    grunt.initConfig({
        // Metadata
        pkg: grunt.file.readJSON('package.json'),
        banner: '/*! <%= pkg.name %> - v<%= pkg.version %> - ' +
            '<%= grunt.template.today("yyyy-mm-dd") %>\n' +
            '<%= pkg.homepage ? "* " + pkg.homepage + "\\n" : "" %>' +
            '* Copyright (c) <%= grunt.template.today("yyyy") %> <%= pkg.author.name %>;' +
            ' Licensed <%= props.license %> */\n',
        // Task configuration

        // Main CSS plugin
        cssmin: {
            combine: {
                files: {
                    'app/css/main.min.css': ['app/css/content.css', 'app/css/sidebar.css']
                }
            }
        },

        concat: {
            js: {
                src: ['app/js/main.min.js'],
                dest: 'build/assets/js/app.js',
            },
            css: {
                src: ['app/css/main.min.css'],
                dest: 'build/assets/css/style.css',
            }
        },
        uglify: {
            dist: {
                files: {
                    'app/js/main.min.js': ['app/js/toggle.js']
                }
            }
        },
        jshint: {
            options: {
                node: true,
                curly: true,
                eqeqeq: true,
                immed: true,
                latedef: true,
                newcap: true,
                noarg: true,
                sub: true,
                undef: true,
                unused: true,
                eqnull: true,
                browser: true,
                globals: {
                    jQuery: true
                },
                boss: true
            },
            gruntfile: {
                src: 'gruntfile.js'
            },
            lib_test: {
                src: ['lib/**/*.js', 'test/**/*.js']
            }
        },
        qunit: {
            files: ['test/**/*.html']
        },
        watch: {
            js: {
                files: ['app/js/*.js'],
                tasks: ['concat:js']
            },
            css: {
                files: ['app/css/*.css'],
                tasks: ['concat:css']
            }
        }
    });

    // These plugins provide necessary tasks
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-qunit');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-watch');

    // Default task
    grunt.registerTask('default', ['jshint', 'qunit', 'cssmin', 'uglify', 'concat', 'watch']);
};