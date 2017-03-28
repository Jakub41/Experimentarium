module.exports = function (grunt) {
    grunt.registerTask("default", "", function () {
        grunt.log.write("This grunt task is pointless!!!");

        // Time how long tasks take. Can help when optimizing build times
        require('time-grunt')(grunt);
    });
};