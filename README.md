vs-ng-template
==============

With many thanks to [kriasoft](https://github.com/kriasoft/) for his most awesome [Visual Studio AngularJS SPA Template](https://github.com/kriasoft/AngularJS-SPA-Template).

I love just about everything about the template except I had a much larger application to develop where moving controllers closer to their views would simplify developers work when changing a view.

Requirements
------------

 [Web Essentials 2013](http://vswebessentials.com/download)
I had issues with the current version of Web Essentials ignoring my exclude list. I had to upgrade to VS2013 Update 2 and [Web Essentials Nightly Builds](http://madskristensen.net/post/web-essentials-nightly-builds)

Scope
-----
Setup a basic angular template with a directory structure suitable for larger applications. Following [Google's Best Practices](https://docs.google.com/document/d/1XXMvReO8-Awi1EZXAXS4PzDzdNvV6pGcuaF4Q9821Es/pub).


Future Direction
----------------

In no particular order:

- Add a template for Web API.
- Run JSCS and JSHint on build so checkins can be rejected when issues are encountered.
- Load controller's minified javascript on demand.
- Clear the Google Analytics story with a 'production' and 'staging' flag that report to different Analytics properties.
- Log and server side storage of javascript errors.

