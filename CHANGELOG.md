# Changelog

## [4.0.0](https://github.com/hermanho/postal.aspnetcore/compare/v3.1.0...v4.0.0) (2024-03-21)


### ⚠ BREAKING CHANGES

* Update CICD to .Net 7, .Net 8

### Features

* compatible to Hangfire and Json.Net, fix [#28](https://github.com/hermanho/postal.aspnetcore/issues/28) ([b99849f](https://github.com/hermanho/postal.aspnetcore/commit/b99849f3e241b2083cd6ca365484abdc19d17c0d))
* Support .Net 7, .Net  8 ([fedf6b9](https://github.com/hermanho/postal.aspnetcore/commit/fedf6b92b76d621bfa9c0bc45bc54078a4739f3d))
* Update CICD to .Net 7, .Net 8 ([d354dde](https://github.com/hermanho/postal.aspnetcore/commit/d354ddee84a6c96d848e7c68283c53c0377cb104))


### Bug Fixes

* test files ([85100fc](https://github.com/hermanho/postal.aspnetcore/commit/85100fcb12272142175ac51ad7f505f98654b542))

## [3.1.0](https://github.com/hermanho/postal.aspnetcore/compare/Postal.AspNetCore-v3.0.0...Postal.AspNetCore-v3.1.0) (2023-09-14)


### Features

* update dependency ([4e23072](https://github.com/hermanho/postal.aspnetcore/commit/4e23072ac56f2e2f034d343cb29919003790e1f0))
* use endpoint routing ([c4d6e98](https://github.com/hermanho/postal.aspnetcore/commit/c4d6e98636fc3c2612d8c8384b34ad4b5b3084ec))


### Bug Fixes

* cicd ([1f7a908](https://github.com/hermanho/postal.aspnetcore/commit/1f7a90855a523b30bdd55555f21514b539dbc726))
* Headers are read-only, response has already started ([d8ff521](https://github.com/hermanho/postal.aspnetcore/commit/d8ff5211a2621bdd78684417e2724770b2269c5e))
* null check ([6ff20eb](https://github.com/hermanho/postal.aspnetcore/commit/6ff20eb44c18525152e7b29dbe1fc15373a95d49))
* remove tools directory ([3e69864](https://github.com/hermanho/postal.aspnetcore/commit/3e6986450c82438e8d0c88088bbb21b58b2394cf))
* test case ([1d44737](https://github.com/hermanho/postal.aspnetcore/commit/1d44737ec4c79af17dfacb21b0b1bb89aa3958b4))

## [3.0.0](https://github.com/hermanho/postal.aspnetcore/compare/Postal.AspNetCore-v3.0.0-pre.3...Postal.AspNetCore-v3.0.0) (2023-09-12)


### Features

* Support .Net 6.0 ([fd3ad88](https://github.com/hermanho/postal.aspnetcore/commit/fd3ad88e1d3482510ab04d6f56e9fa2d59cd2d66))


### Bug Fixes

* 26 - Correctly build alternative view names from full path. ([f116bf4](https://github.com/hermanho/postal.aspnetcore/commit/f116bf4dcad3156a553aeec394ce1b83461582e7))
* github action ([0c5b481](https://github.com/hermanho/postal.aspnetcore/commit/0c5b481197a6d2183986df35898bfb9e21cb4304))
* github workflow ([66b26bd](https://github.com/hermanho/postal.aspnetcore/commit/66b26bd35c54f17f2f2ab3cf4f929dfb8efe6b79))
* migrate to github action ([8840647](https://github.com/hermanho/postal.aspnetcore/commit/8840647cce22c282481391baf969a8707e2b1922))
* workflow ([a806911](https://github.com/hermanho/postal.aspnetcore/commit/a8069118dd13a8ea712c0a730bf393ea41dee685))


### Miscellaneous Chores

* release 3.0.0-pre ([301a0f2](https://github.com/hermanho/postal.aspnetcore/commit/301a0f2df9502eb2d96eae8de6225e3c643aa7cb))

## [3.0.0-pre.3](https://github.com/hermanho/postal.aspnetcore/compare/v3.0.2-pre.2...v3.0.0-pre.3) (2023-03-29)


### Bug Fixes

* workflow ([a806911](https://github.com/hermanho/postal.aspnetcore/commit/a8069118dd13a8ea712c0a730bf393ea41dee685))

## [3.0.2-pre.2](https://github.com/hermanho/postal.aspnetcore/compare/v3.0.1-pre.2...v3.0.2-pre.2) (2023-03-29)


### Bug Fixes

* github workflow ([66b26bd](https://github.com/hermanho/postal.aspnetcore/commit/66b26bd35c54f17f2f2ab3cf4f929dfb8efe6b79))

## [3.0.1-pre.2](https://github.com/hermanho/postal.aspnetcore/compare/v3.0.0-pre.2...v3.0.1-pre.2) (2023-03-28)


### Bug Fixes

* github action ([0c5b481](https://github.com/hermanho/postal.aspnetcore/commit/0c5b481197a6d2183986df35898bfb9e21cb4304))

## [3.0.0-pre.2](https://github.com/hermanho/postal.aspnetcore/compare/v2.7.1...v3.0.0-pre.2) (2023-03-28)


### Bug Fixes

* migrate to github action ([8840647](https://github.com/hermanho/postal.aspnetcore/commit/8840647cce22c282481391baf969a8707e2b1922))


### Miscellaneous Chores

* release 3.0.0-pre ([301a0f2](https://github.com/hermanho/postal.aspnetcore/commit/301a0f2df9502eb2d96eae8de6225e3c643aa7cb))

## [v2.7.1](https://github.com/hermanho/postal.aspnetcore/tree/v2.7.1) (2020-12-12)

**Fixing:**
- Fix no header in email template will throw exception

## [v2.6.0](https://github.com/hermanho/postal.aspnetcore/tree/v2.6.0) (2020-01-16)

**Implemented enhancements:**
- Support Connection String when configure EmailServiceOptions ([@the-avid-engineer](https://github.com/the-avid-engineer) in [#11](https://github.com/hermanho/postal.aspnetcore/pull/11))

## [v2.5.0](https://github.com/hermanho/postal.aspnetcore/tree/v2.5.0) (2020-01-13)

**Support netcoreapp3.1**

## [v2.3.0](https://github.com/hermanho/postal.aspnetcore/tree/v2.3.0) (2019-03-18)

**Implemented enhancements:**
- Support all templates under the views folder

## [v2.2.1.1](https://github.com/hermanho/postal.aspnetcore/tree/v2.2.1.1) (2018-12-11)

**Implemented enhancements:**
- Decouple "Func\<SmtpClient\>" into "IOptions\<EmailServiceOptions\>" in EmailService constructor for dependency injection
- Allow SendAsync with MailMessage in EmailService

## [v2.1.7](https://github.com/hermanho/postal.aspnetcore/tree/v2.1.7) (2018-11-30)

**Implemented enhancements:**
- Support for style attribute in image attachment ([@amitmittal](https://github.com/amitmittal) in [#5](https://github.com/hermanho/postal.aspnetcore/pull/5))

**Fixing:**
- Fix bugs in image attachment. ([@amitmittal](https://github.com/amitmittal) in [#5](https://github.com/hermanho/postal.aspnetcore/pull/5))

## [v2.1.6](https://github.com/hermanho/postal.aspnetcore/tree/v2.1.6) (2018-11-20)

**Fixing:**
- Fix bugs in ImageEmbedder. ([@amitmittal](https://github.com/amitmittal) in [#2](https://github.com/hermanho/postal.aspnetcore/pull/2))

## [v2.1.5](https://github.com/hermanho/postal.aspnetcore/tree/v2.1.5) (2018-10-12)

**Implemented enhancements:**
- Allow pass RequestPath and RouteData in TemplateService and Razor

## [v2.1.3](https://github.com/hermanho/postal.aspnetcore/tree/f15bbc2993c1812e9cff3fca01fd717c44a675c8) (2018-09-14)

**Fixing:**
- Fix ViewDataDictionary / ViewBag do not pass to ViewContext

## [v2.1.2](https://github.com/hermanho/postal.aspnetcore/tree/063b4e21f002406f10f4a0a8a06155d333ecbb20) (2018-09-06)

**Implemented enhancements:**
- Add namespace in templateservice

## [v2.1.1](https://github.com/hermanho/postal.aspnetcore/tree/5b8324c8e6091e2c59541c43cd524cc4ad9454ca) (2018-09-06)

**Implemented enhancements:**
- Add ServiceCollectionExtensions for DI

## [v2.1.0](https://github.com/hermanho/postal.aspnetcore/tree/95a101e2f0b2496452abf9ede640e6d0fcd7522b) (2018-09-06)

**Implemented enhancements:**
- Say goodbye to RazorEngine 😀
