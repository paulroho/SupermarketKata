## Supermarket Kata in [Go](https://www.golang.org)

This implementation requires Go in version 1.7 or compatible.

### Setup

This project uses relative import paths, in order to avoid having a name of a person in the package path. This avoids problems after forking the kata repo.

You will need to install the following libraries in the source directory of your regular GOPATH. (Refer to the Go homepage for installing and [testing](https://golang.org/doc/install#testing) your Go setup itself).

```
(in your <GOPATH>/src directory)
go get github.com/DATA-DOG/godog
go get github.com/stvp/assert
```

Afterwards, create the binary for godog in order to execute the tests.
```
(in your <GOPATH>/src directory)
cd github.com/DATA-DOG/godog
go install ./...
```

[Godog](https://github.com/DATA-DOG/godog) is the BDD testing framework and ```assert``` is for simple assertions in some unit tests.


### Running tests

For the feature tests, enter the ```supermarket``` directory and run ```godog``` from your ```GOPATH/bin``` directory, i.e.:
```
.../supermarket> (gopath)/bin/godog
```
