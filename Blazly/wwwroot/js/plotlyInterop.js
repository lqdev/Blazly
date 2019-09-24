// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.plotlyFunctions = {
    newPlot: function (id, traces = [], layout = {}) {
        Plotly.newPlot(id, traces, layout);
    }
};
