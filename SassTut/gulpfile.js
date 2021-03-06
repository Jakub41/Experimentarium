//Gulp plugin
var gulp = require("gulp"), //http://gulpjs.com/
    util = require("gulp-util"), //https://github.com/gulpjs/gulp-util
    sass = require("gulp-sass"), //https://www.npmjs.org/package/gulp-sass
    autoprefixer = require('gulp-autoprefixer'), //https://www.npmjs.org/package/gulp-autoprefixer
    minifycss = require('gulp-clean-css'), //https://www.npmjs.org/package/gulp-minify-css
    rename = require('gulp-rename'), //https://www.npmjs.org/package/gulp-rename
    log = util.log;

var sassFiles = "./scss/*.scss";
var browserSync = require('browser-sync').create();

gulp.task('browserSync', function() {
    browserSync.init({
        server: {
            baseDir: 'app'
        },
    });
});

gulp.task("sass", function() {
    log("Generate CSS files " + (new Date()).toString());
    gulp.src(sassFiles)
        .pipe(sass({ style: 'expanded' }))
        .pipe(autoprefixer("last 3 version", "safari 5", "ie 8", "ie 9"))
        .pipe(minifycss({ compatibility: 'ie8' }))
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest("./app/css/"))
        .pipe(browserSync.reload({
            stream: true
        }));
});

gulp.task("watch", ['browserSync', 'sass'], function() {
    log("Watching scss files for modifications");
    gulp.watch(sassFiles, ["sass"]);
    gulp.watch('*.html', browserSync.reload);
    gulp.watch('*.js', browserSync.reload);
});

gulp.task("default", ["sass"]);