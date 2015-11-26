﻿function TaskDetailViewModel() {
    var self = this;
    self.Id = ko.observable();

    self.Name = ko.observable();
    self.Number = ko.observable();
    self.Date = ko.observable();
    self.Type = ko.observable();
    self.IsInternal = ko.observable();
    self.Amount = ko.observable();
    self.CustomerId = ko.observable();
    self.TypeId = ko.observable();
    self.TypeName = ko.observable();
    self.PlannedTime = ko.observable();
    self.PlanningDate = ko.observable();
    self.PlannedStartDate = ko.observable();
    self.PlannedEndDate = ko.observable();
    self.Description = ko.observable();
    self.Color = ko.observable();
    self.Progress = ko.observable();

    function fill(data) {
        ko.ext.updateViewModel(self, data);
    }

    self.init = function (id) {
        service.getTask(id, fill);
        //service.getTaskType(self.TypeName, self.TypeId);
    }

}