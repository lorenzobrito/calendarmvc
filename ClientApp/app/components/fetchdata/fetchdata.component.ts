import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';
@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: WeatherForecast[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as WeatherForecast[];
        }, error => console.error(error));
    }
    events: string[] = [];

    addEvent(type: string, event: MatDatepickerInputEvent<Date>) {
        this.events.push(`${type}: ${event.value}`);
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}
