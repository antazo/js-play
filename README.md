# js-play

Testing the different JS libraries and frameworks under a .NET environment.

For this project we are going to use:

* **BACKEND**: ASP.NET Core Web API
* **FRONTEND**: React.js

## Installation

Clone (or fork) this repository:

```powershell
git clone https://github.com/antazo/js-play
cd js-play
```

Run the backend and the frontend in different terminals:

* **BACKEND**:

```powershell
cd backend
dotnet run
```

Try it: <http://127.0.0.1:5210/>

* **FRONTEND**:

```powershell
cd ../frontend
npm start
```

Try it: <http://127.0.0.1:3000/>

## Documentation

Follow these steps to create the project **js-play** from the scratch.

Create the **backend** with a new ASP.NET Core Web API project:

```powershell
dotnet new webapi -n backend
```

For the **frontend**, make sure that you have Node.js installed, it is needed for the `npm` (Node Package Manager). Then, proceed by creating the React app:

```powershell
npx create-react-app frontend
```

>The package "babel-preset-react-app" is not maintained anymore, and the plugin "@babel/plugin-proposal-private-property-in-object" was merge to ECMAScript.
>
>To avoid the warning messages when starting `npm`, add `@babel/plugin-transform-private-property-in-object` to devDependencies to work around this error.
>
>Check if it is present in your **package.json**, then just `npm install`. Or do this:
>
>```powershell
>npm install --save-dev @babel/plugin-transform-private-property-in-object
>```
