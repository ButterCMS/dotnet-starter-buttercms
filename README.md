# .NET ButterCMS Starter Project

This .NET starter project fully integrates with dynamic sample content from your ButterCMS account, including main menu, pages, blog posts, categories, and tags, all with a beautiful, custom theme with already-implemented search functionality. All of the included sample content is automatically created in your account dashboard when you sign up for a free trial of ButterCMS.

You can view a [live demo hosted on Heroku](https://dotnet-starter-buttercms.herokuapp.com/), or you can click the button below to deploy your own copy of our starter project to the provider of your choice.

[![Deploy](https://www.herokucdn.com/deploy/button.svg)](https://heroku.com/deploy?template=https://github.com/ButterCMS/dotnet-starter-buttercms&env%5ButterCMSAPIKey%5D=check%20https://buttercms.com/settings)

## Prerequisites

- `.NET Core SDK` at 8.0 or higher

## 1. Installation

First, clone the repo and install the dependencies by running `dotnet restore`:

```console
$ git clone https://github.com/ButterCMS/dotnet-starter-buttercms.git

$ cd dotnet-starter-buttercms

$ dotnet restore
```

### 2. Set API Token

To fetch your ButterCMS content, add your API token as an environment variable.

```console
$ dotnet user-secrets set "ButterCMSAPIKey" "<YOUR API Token>" --project ButterCMS.Starter
```

### 3. Run local server

To view the app in the browser, you'll need to run the local development server:

```console
$ dotnet run --project ButterCMS.Starter
```

Congratulations! Your starter project is now live. To view your project, point your browser to [http://localhost:5000](http://localhost:5000).

### 4) Deploy on Heroku

Our starter app can be deployed to Heroku with the click of a button:

1. Create a Heroku account at https://signup.heroku.com.
2. Click the button below and fill in an app name and your Butter API token. Then click "deploy".

[![Deploy](https://www.herokucdn.com/deploy/button.svg)](https://heroku.com/deploy?template=https://github.com/ButterCMS/dotnet-starter-buttercms&env%5ButterCMSAPIKey%5D=check%20https://buttercms.com/settings)

### 5.) Previewing and Draft Changes

By default, your starter project is set up to allow previewing of draft changes saved in your ButterCMS.com account. To disable this functionality, set `ButterCMSPreview` value to `false` in your environment variables or `appsettings.json`. Note that a value set in your environment variables takes precedence over `appsettings.json`.

To set in environment variables on **Mac/Linux**:

```console
$ export ButterCMSPreview=false
```

To set in environment variables on **Windows**:

```console
$ set ButterCMSPreview=false
```

For **PowerShell** use:

```console
$env:ButterCMSPreview="false"
```
