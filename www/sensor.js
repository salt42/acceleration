module.exports = {
    getMinInterval: function (successCallback, errorCallback) {
        cordova.exec(successCallback, errorCallback || function () { }, "Sensor", "getMinInterval", "");
    },
    watch: function (intervalTime, successCallback, errorCallback) {
        var interval = setInterval(function () {
            cordova.exec(function (d) {
                //prepare data
                console.log(d)
                //successCallback();
            }, errorCallback, "Sensor", "getData", "");
        }, intervalTime);
        return function stopWatch(){
            //stop Watching
            interval.clear();
        }
    }
};
