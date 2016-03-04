
import {HttpClient} from "aurelia-fetch-client";
import {autoinject} from "aurelia-framework";

@autoinject
export class Projects {
    public featuredProject: any;
    public projects: any[];

    constructor(private http: HttpClient) {
        http.configure(config => {
          config.useStandardConfiguration();
        });
    }

    activate() {
      return this.http.fetch("api/projects")
        .then(response => response.json())
        .then((projectModel) => {
          this.featuredProject = projectModel.featuredProject;
          this.projects = projectModel.projects;
        });
    }
}
