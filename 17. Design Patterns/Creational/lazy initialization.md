


<!DOCTYPE html>
<html lang="en" class=" is-copy-enabled">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta name="viewport" content="width=1020">
    
    
    <title>Telerik-Academy-HW/lazy initialization.md at master · antoanelenkov/Telerik-Academy-HW</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="antoanelenkov/Telerik-Academy-HW" name="twitter:title" /><meta content="Telerik-Academy-HW - All of my Telerik homeworks" name="twitter:description" /><meta content="https://avatars1.githubusercontent.com/u/10462211?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars1.githubusercontent.com/u/10462211?v=3&amp;s=400" property="og:image" /><meta content="antoanelenkov/Telerik-Academy-HW" property="og:title" /><meta content="https://github.com/antoanelenkov/Telerik-Academy-HW" property="og:url" /><meta content="Telerik-Academy-HW - All of my Telerik homeworks" property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/MTA1MDU3MTA6ZjA4OTVjMWQ1MmQ3M2Y5NWI4NzNhMmIyNDNhZTFkNTY6MDY3ZDhkYWJlYTAxN2VmZjc5MjgxYzgyN2Y4NGMxNDYwOTdlNjE3ZGEzZGJhYWI0NjI3OWJkMGU3MmYyYjViYQ==--181cdcca02423a5737fa8dbf191af9c7240e5184">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>

    <meta name="google-site-verification" content="KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU">
        <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="4E5A4312:1495:163A698:55F527D0" name="octolytics-dimension-request_id" /><meta content="10505710" name="octolytics-actor-id" /><meta content="plamenvt" name="octolytics-actor-login" /><meta content="671c2eb5880a305b60bdcf837097861a509d906d5b97e99f6b70bf9ae9198102" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" data-pjax-transient="true" name="analytics-event" />
    <meta class="js-ga-set" name="dimension1" content="Logged In">
      <meta class="js-ga-set" name="dimension4" content="Current repo nav">
    <meta name="is-dotcom" content="true">
        <meta name="hostname" content="github.com">
    <meta name="user-login" content="plamenvt">

      <link rel="mask-icon" href="https://assets-cdn.github.com/pinned-octocat.svg" color="#4078c0">
      <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">

    <!-- </textarea> --><!-- '"` --><meta content="authenticity_token" name="csrf-param" />
<meta content="gEq0MCqqkRj0G5UHz+8s5B0+lQHu9ZBJ+/Vzb9pyDa1qZlM5Usp6ahvNQdFbxbhVWjavx5zE2pZv+dQ3TmdWXg==" name="csrf-token" />
    <meta content="72555f72e08492715aae10d9099549d8cbab70dd" name="form-nonce" />

    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github-a14e3d6410d6fd1b2fa98e4e859a3bd1fb7c3b71f16c511481f068705c04d6a5.css" media="all" rel="stylesheet" />
    <link crossorigin="anonymous" href="https://assets-cdn.github.com/assets/github2-ddeb1c89541d4a66272d529e53eea795596f88651e3227883c8d99a59d7e0ec5.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="e025af83f90d59b969df6cecbfb86c10">

      
  <meta name="description" content="Telerik-Academy-HW - All of my Telerik homeworks">
  <meta name="go-import" content="github.com/antoanelenkov/Telerik-Academy-HW git https://github.com/antoanelenkov/Telerik-Academy-HW.git">

  <meta content="10462211" name="octolytics-dimension-user_id" /><meta content="antoanelenkov" name="octolytics-dimension-user_login" /><meta content="40790456" name="octolytics-dimension-repository_id" /><meta content="antoanelenkov/Telerik-Academy-HW" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="40790456" name="octolytics-dimension-repository_network_root_id" /><meta content="antoanelenkov/Telerik-Academy-HW" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/antoanelenkov/Telerik-Academy-HW/commits/master.atom" rel="alternate" title="Recent Commits to Telerik-Academy-HW:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>

    
    
    



      <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/antoanelenkov/Telerik-Academy-HW/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/antoanelenkov/Telerik-Academy-HW/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <label class="js-chromeless-input-container form-control">
    <div class="scope-badge">This repository</div>
    <input type="text"
      class="js-site-search-focus js-site-search-field is-clearable chromeless-input"
      data-hotkey="s"
      name="q"
      placeholder="Search"
      aria-label="Search this repository"
      data-global-scope-placeholder="Search GitHub"
      data-repo-scope-placeholder="Search"
      tabindex="1"
      autocapitalize="off">
  </label>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item">
          <a href="/pulls" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:pulls context:user" data-hotkey="g p" data-selected-links="/pulls /pulls/assigned /pulls/mentioned /pulls">
            Pull requests
</a>        </li>
        <li class="header-nav-item">
          <a href="/issues" class="js-selected-navigation-item header-nav-link" data-ga-click="Header, click, Nav menu - item:issues context:user" data-hotkey="g i" data-selected-links="/issues /issues/assigned /issues/mentioned /issues">
            Issues
</a>        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com/" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item">
      <span class="js-socket-channel js-updatable-content"
        data-channel="notification-changed:plamenvt"
        data-url="/notifications/header">
      <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
          <span class="mail-status all-read"></span>
          <span class="octicon octicon-bell"></span>
</a>  </span>

  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link tooltipped tooltipped-s js-menu-target" href="/new"
       aria-label="Create new…"
       data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus left"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu dropdown-menu-sw">
        
<a class="dropdown-item" href="/new" data-ga-click="Header, create new repository">
  New repository
</a>


  <a class="dropdown-item" href="/organizations/new" data-ga-click="Header, create new organization">
    New organization
  </a>



  <div class="dropdown-divider"></div>
  <div class="dropdown-header">
    <span title="antoanelenkov/Telerik-Academy-HW">This repository</span>
  </div>
    <a class="dropdown-item" href="/antoanelenkov/Telerik-Academy-HW/issues/new" data-ga-click="Header, create new issue">
      New issue
    </a>

      </ul>
    </div>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name tooltipped tooltipped-s js-menu-target" href="/plamenvt"
       aria-label="View profile and more"
       data-ga-click="Header, show menu, icon:avatar">
      <img alt="@plamenvt" class="avatar" height="20" src="https://avatars2.githubusercontent.com/u/10505710?v=3&amp;s=40" width="20" />
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <div class="dropdown-menu dropdown-menu-sw">
        <div class="dropdown-header header-nav-current-user css-truncate">
          Signed in as <strong class="css-truncate-target">plamenvt</strong>
        </div>
        <div class="dropdown-divider"></div>

        <a class="dropdown-item" href="/plamenvt" data-ga-click="Header, go to profile, text:your profile">
          Your profile
        </a>
        <a class="dropdown-item" href="/stars" data-ga-click="Header, go to starred repos, text:your stars">
          Your stars
        </a>
        <a class="dropdown-item" href="/explore" data-ga-click="Header, go to explore, text:explore">
          Explore
        </a>
        <a class="dropdown-item" href="https://help.github.com" data-ga-click="Header, go to help, text:help">
          Help
        </a>
        <div class="dropdown-divider"></div>

        <a class="dropdown-item" href="/settings/profile" data-ga-click="Header, go to settings, icon:settings">
          Settings
        </a>

        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/logout" class="logout-form" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="8ebxVVPG5dKoVI3U3KpTQHc26Kh4U02HcjdQcFbudwkuUEdDBk6cQ4u+hSbwqXd5h7vp/wy39CD5BfcfwEoXBw==" /></div>
          <button class="dropdown-item dropdown-signout" data-ga-click="Header, sign out, icon:logout">
            Sign out
          </button>
</form>      </div>
    </div>
  </li>
</ul>


    
  </div>
</div>

      

      


    <div id="start-of-content" class="accessibility-aid"></div>

    <div id="js-flash-container">
</div>


    <div role="main" class="main-content">
        <div itemscope itemtype="http://schema.org/WebPage">
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">

        <div class="clearfix">
          
<ul class="pagehead-actions">

  <li>
      <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="N9ZNjE0sreVyJPxzgIa1R0Df2n4jj/7YJW1nKNVauCmxJAYgLpWl0fY0rjLi9Z8ReHhACCup4oYWz62hbhyC+Q==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="40790456" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/antoanelenkov/Telerik-Academy-HW/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Watch
          </span>
        </a>
        <a class="social-count js-social-count" href="/antoanelenkov/Telerik-Academy-HW/watchers">
          1
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/antoanelenkov/Telerik-Academy-HW/unstar" class="js-toggler-form starred js-unstar-button" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="g4ZD43kwGbmxQXCkRUdRMJxyTmE/iNe/ZV3WUK0SbbsJBdDi66n9ziLPvJqEEm+RI2lnLVJe8yLck9dKduQFIw==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar antoanelenkov/Telerik-Academy-HW"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/antoanelenkov/Telerik-Academy-HW/stargazers">
          0
        </a>
</form>
    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/antoanelenkov/Telerik-Academy-HW/star" class="js-toggler-form unstarred js-star-button" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="6NEd9haRyFV3Cm2M7ggG1TkD3gbIrZIADkHZJtXFi52dzCCxQs3VEmGw9nETSIbj3FcqivfceUchpTzs1O5aPQ==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star antoanelenkov/Telerik-Academy-HW"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/antoanelenkov/Telerik-Academy-HW/stargazers">
          0
        </a>
</form>  </div>

  </li>

        <li>
          <a href="#fork-destination-box" class="btn btn-sm btn-with-count"
              title="Fork your own copy of antoanelenkov/Telerik-Academy-HW to your account"
              aria-label="Fork your own copy of antoanelenkov/Telerik-Academy-HW to your account"
              rel="facebox"
              data-ga-click="Repository, show fork modal, action:blob#show; text:Fork">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/antoanelenkov/Telerik-Academy-HW/network" class="social-count">0</a>

          <div id="fork-destination-box" style="display: none;">
            <h2 class="facebox-header" data-facebox-id="facebox-header">Where should we fork this repository?</h2>
            <include-fragment src=""
                class="js-fork-select-fragment fork-select-fragment"
                data-url="/antoanelenkov/Telerik-Academy-HW/fork?fragment=1">
              <img alt="Loading" height="64" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-128.gif" width="64" />
            </include-fragment>
          </div>
        </li>

</ul>

          <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public ">
  <span class="mega-octicon octicon-repo"></span>
  <span class="author"><a href="/antoanelenkov" class="url fn" itemprop="url" rel="author"><span itemprop="title">antoanelenkov</span></a></span><!--
--><span class="path-divider">/</span><!--
--><strong><a href="/antoanelenkov/Telerik-Academy-HW" data-pjax="#js-repo-pjax-container">Telerik-Academy-HW</a></strong>

  <span class="page-context-loader">
    <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
  </span>

</h1>

        </div>
      </div>
    </div>

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline ">
        <div class="repository-sidebar clearfix">
          
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/antoanelenkov/Telerik-Academy-HW/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/antoanelenkov/Telerik-Academy-HW" aria-label="Code" aria-selected="true" class="js-selected-navigation-item selected sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /antoanelenkov/Telerik-Academy-HW">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/antoanelenkov/Telerik-Academy-HW/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /antoanelenkov/Telerik-Academy-HW/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/antoanelenkov/Telerik-Academy-HW/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /antoanelenkov/Telerik-Academy-HW/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Wiki">
        <a href="/antoanelenkov/Telerik-Academy-HW/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g w" data-selected-links="repo_wiki /antoanelenkov/Telerik-Academy-HW/wiki">
          <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/antoanelenkov/Telerik-Academy-HW/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /antoanelenkov/Telerik-Academy-HW/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/antoanelenkov/Telerik-Academy-HW/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /antoanelenkov/Telerik-Academy-HW/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>    </li>
  </ul>


</nav>

            <div class="only-with-full-nav">
                
<div class="js-clone-url clone-url open"
  data-protocol-type="http">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/antoanelenkov/Telerik-Academy-HW.git" readonly="readonly" aria-label="HTTPS clone URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="ssh">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:antoanelenkov/Telerik-Academy-HW.git" readonly="readonly" aria-label="SSH clone URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="js-clone-url clone-url "
  data-protocol-type="subversion">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/antoanelenkov/Telerik-Academy-HW" readonly="readonly" aria-label="Subversion checkout URL">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



  <div class="clone-options">You can clone with
    <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="RFxbM+t3+DeI5P9UH9IRgS6LrFWAFaP4Kgm1r7GazE3TIJjo4jZ5vQmSfTyU+7WmSR6l5XscVI68U5x9onYFPA==" /></div><button class="btn-link js-clone-selector" data-protocol="http" type="submit">HTTPS</button></form>, <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ZklcXorKoTEp0RgQuRKv3375xgJUJ9xRyBjcvYd/6BJEtNX7rn3jb4E5U5DKHhGeYcTNqauOzWYiBOwDJlz+pQ==" /></div><button class="btn-link js-clone-selector" data-protocol="ssh" type="submit">SSH</button></form>, or <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone" class="inline-form js-clone-selector-form is-enabled" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="JviKzR1zyF/XTampYRC7Eg6s7zoz/GZWbiYrBuBrmAK3gglxbdcxkSa8VarRNSRE8GlYUBn+WIvh62FyQd5Kug==" /></div><button class="btn-link js-clone-selector" data-protocol="subversion" type="submit">Subversion</button></form>.
    <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
      <span class="octicon octicon-question"></span>
    </a>
  </div>
    <a href="github-windows://openRepo/https://github.com/antoanelenkov/Telerik-Academy-HW" class="btn btn-sm sidebar-button" title="Save antoanelenkov/Telerik-Academy-HW to your computer and use it in GitHub Desktop." aria-label="Save antoanelenkov/Telerik-Academy-HW to your computer and use it in GitHub Desktop.">
      <span class="octicon octicon-desktop-download"></span>
      Clone in Desktop
    </a>

              <a href="/antoanelenkov/Telerik-Academy-HW/archive/master.zip"
                 class="btn btn-sm sidebar-button"
                 aria-label="Download the contents of antoanelenkov/Telerik-Academy-HW as a zip file"
                 title="Download the contents of antoanelenkov/Telerik-Academy-HW as a zip file"
                 rel="nofollow">
                <span class="octicon octicon-cloud-download"></span>
                Download ZIP
              </a>
            </div>
        </div>
        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>

          

<a href="/antoanelenkov/Telerik-Academy-HW/blob/310d53ec51942322f19990b326384f41258e5cd0/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:e6710ea86fa123dd6d95a7789dd6ba86 -->

  <div class="file-navigation js-zeroclipboard-container">
    
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <i>Branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab" role="tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab" role="tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches" role="menu">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/antoanelenkov/Telerik-Academy-HW/blob/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

    <div class="btn-group right">
      <a href="/antoanelenkov/Telerik-Academy-HW/find/master"
            class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-nw"
            data-pjax
            data-hotkey="t"
            aria-label="Quickly jump between files">
        <span class="octicon octicon-list-unordered"></span>
      </a>
      <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </div>

    <div class="breadcrumb js-zeroclipboard-target">
      <span class="repo-root js-repo-root"><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/antoanelenkov/Telerik-Academy-HW" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Telerik-Academy-HW</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/antoanelenkov/Telerik-Academy-HW/tree/master/C%23HighQuality_Homeworks" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">C#HighQuality_Homeworks</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/antoanelenkov/Telerik-Academy-HW/tree/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">14.Homework.DesignPatterns</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/antoanelenkov/Telerik-Academy-HW/tree/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational" class="" data-branch="master" data-pjax="true" itemscope="url"><span itemprop="title">Creational</span></a></span><span class="separator">/</span><strong class="final-path">lazy initialization.md</strong>
    </div>
  </div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="@antoanelenkov" class="avatar" height="24" src="https://avatars0.githubusercontent.com/u/10462211?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/antoanelenkov" rel="author">antoanelenkov</a></span>
        <time datetime="2015-09-12T14:39:13Z" is="relative-time">Sep 12, 2015</time>
        <div class="commit-title">
            <a href="/antoanelenkov/Telerik-Academy-HW/commit/1e0c28ec6d004f0394628df307cd7398f91b8bd5" class="message" data-pjax="true" title="HW is ready">HW is ready</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>1</strong>
           contributor
        </a>
      </p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header" data-facebox-id="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list" data-facebox-id="facebox-description">
          <li class="facebox-user-list-item">
            <img alt="@antoanelenkov" height="24" src="https://avatars0.githubusercontent.com/u/10462211?v=3&amp;s=48" width="24" />
            <a href="/antoanelenkov">antoanelenkov</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
  <div class="file-actions">

    <div class="btn-group">
      <a href="/antoanelenkov/Telerik-Academy-HW/raw/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="btn btn-sm " id="raw-url">Raw</a>
        <a href="/antoanelenkov/Telerik-Academy-HW/blame/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
      <a href="/antoanelenkov/Telerik-Academy-HW/commits/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="btn btn-sm " rel="nofollow">History</a>
    </div>

      <a class="octicon-btn tooltipped tooltipped-nw"
         href="github-windows://openRepo/https://github.com/antoanelenkov/Telerik-Academy-HW?branch=master&amp;filepath=C%23HighQuality_Homeworks%2F14.Homework.DesignPatterns%2FCreational%2Flazy%20initialization.md"
         aria-label="Open this file in GitHub Desktop"
         data-ga-click="Repository, open with desktop, type:windows">
          <span class="octicon octicon-device-desktop"></span>
      </a>

        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/antoanelenkov/Telerik-Academy-HW/edit/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="inline-form js-update-url-with-hash" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="wfVACaIrVD5oubo9/229ag4XQCYRgrUc7pw694Kn5oM+/LsN0gFe2AlEfaM1CGE6BUAyWvzxpI4c4FfACXhmhA==" /></div>
          <button class="octicon-btn tooltipped tooltipped-nw" type="submit"
            aria-label="Fork this project and edit the file" data-hotkey="e" data-disable-with>
            <span class="octicon octicon-pencil"></span>
          </button>
</form>        <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="/antoanelenkov/Telerik-Academy-HW/delete/master/C%23HighQuality_Homeworks/14.Homework.DesignPatterns/Creational/lazy%20initialization.md" class="inline-form" data-form-nonce="72555f72e08492715aae10d9099549d8cbab70dd" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="MJyvH+PAuRGGr5gCWu+NDHQ6AjAhdQK8GxnljbpNuSiW07zmOSMfQOwra/RzFywQpa4EQUy9vCwZR3qpZpTfXQ==" /></div>
          <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-nw" type="submit"
            aria-label="Fork this project and delete the file" data-disable-with>
            <span class="octicon octicon-trashcan"></span>
          </button>
</form>  </div>

  <div class="file-info">
      66 lines (45 sloc)
      <span class="file-info-divider"></span>
    2.49 KB
  </div>
</div>

  
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-lazy-initialization-pattern" class="anchor" href="#lazy-initialization-pattern" aria-hidden="true"><span class="octicon octicon-link"></span></a>Lazy initialization Pattern</h1>

<h2><a id="user-content-Мотивация" class="anchor" href="#Мотивация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Мотивация</h2>

<ul>
<li>В много случаи се достъпват данни или създават обекти, от които или нямаме нужда веднага или никога не използваме. Този проблем се решава с така наречният шаблон за дизайн 'Lazy initialization pattern', който предотвратява излишно използване на ресурси от програмата ни.</li>
</ul>

<h2><a id="user-content-Цел" class="anchor" href="#Цел" aria-hidden="true"><span class="octicon octicon-link"></span></a>Цел</h2>

<ul>
<li>Служи за  използване на данните в момента, в който имаме нужда от тях</li>
</ul>

<h2><a id="user-content-Приложение" class="anchor" href="#Приложение" aria-hidden="true"><span class="octicon octicon-link"></span></a>Приложение</h2>

<ul>
<li>Пример 1:</li>
</ul>

<p>Нека имаме база с данни. В нея имаме таблица, която се грижи за данните на един студент в училище. Студентът има поредица от курсове, учители, домашни, изпити, оценки и т.н. Използвайки 'Entity Framework' ние имаме възможността да работим с класа 'Student' като всеки един обект от този клас ни представлява запис от базата с данни. Какво би станало ако имаме нужда от оценките на студентите. Ще издърпаме висчки данни за всеки един студент и освен оценките му ще имаме и всичката друга ненужна информация, която хем ще заеме излишна памет, хем ще забави преноса на данни заради обема си. Това би било така, ако 'Entity framework' е писан от студенти преди изпит по КПК :D Но тъй като не е, при създаването на навигационни property-та(това са полета, които сочат към други таблици - например 'курсове', 'учители') те са дефинират като 'virtual' такива и дават възможност вътрешно 'EF' да създава 'proxy' класове, които представляват основните класове(Student)и доставят данните само, когато имаме нужда от тях или с други думи, когато напишем 'currentStudent.grades' и активираме 'get'-a на полето.</p>

<h2><a id="user-content-Известни-употреби" class="anchor" href="#Известни-употреби" aria-hidden="true"><span class="octicon octicon-link"></span></a>Известни употреби</h2>

<ul>
<li>Entity Framework</li>
<li>Singleton design pattern</li>
<li>IQueryable интерфейс - позволява филтрацията да се извършва в базата с данни, след което да се материализира в RAM паметта при нуждата от данните(lazy loading)</li>
</ul>

<h2><a id="user-content-Имплментация" class="anchor" href="#Имплментация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Имплментация</h2>

<pre><code>public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    private IEnumerable&lt;Order&gt; _orders;

    public IEnumerable&lt;Order&gt; Orders
    {
        get
        {
            if (_orders == null)
            {
                _orders = OrdersDatabase.GetOrders(CustomerID);
            }
            return _orders;
        }
    }

    // Constructor
    public Customer(int id, string name)
    {
        CustomerID = id;
        Name = name;
    }
} 
</code></pre>

<h2><a id="user-content-Последствия" class="anchor" href="#Последствия" aria-hidden="true"><span class="octicon octicon-link"></span></a>Последствия</h2>

<ul>
<li>Спестява използвани ресурси.</li>
<li>Предотвратява наличието на излишна и ненужна информация</li>
</ul>

<h2><a id="user-content-Сродни-модели" class="anchor" href="#Сродни-модели" aria-hidden="true"><span class="octicon octicon-link"></span></a>Сродни модели</h2>

<ul>
<li>Не мисля, че има</li>
</ul>

<h2><a id="user-content-Проблеми" class="anchor" href="#Проблеми" aria-hidden="true"><span class="octicon octicon-link"></span></a>Проблеми</h2>

<ul>
<li>Неправилното му използване. При достъпът до скромни ресурси, няма нужда излишно да усложняваме кода ни.</li>
</ul>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <!-- </textarea> --><!-- '"` --><form accept-charset="UTF-8" action="" class="js-jump-to-line-form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" aria-label="Jump to line" autofocus>
    <button type="submit" class="btn">Go</button>
</form></div>

        </div>
      </div>
      <div class="modal-backdrop"></div>
    </div>
  </div>


    </div>

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>
        <li><a href="https://github.com/pricing" data-ga-click="Footer, go to pricing, text:pricing">Pricing</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.10586s from github-fe136-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
        <li><a href="https://help.github.com" data-ga-click="Footer, go to help, text:help">Help</a></li>
    </ul>
  </div>
</div>



    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <button type="button" class="flash-close js-flash-close js-ajax-error-dismiss" aria-label="Dismiss error">
        <span class="octicon octicon-x"></span>
      </button>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-2c67e846b237d12dc49d9ba38bef688797518db6c4fc7ec256caf871623c69e4.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-cdf2812e9b014c7112138481f998b4d18770faa142b62ce3c3223fbf481b6a94.js"></script>
      
      
    <div class="js-stale-session-flash stale-session-flash flash flash-warn flash-banner hidden">
      <span class="octicon octicon-alert"></span>
      <span class="signed-in-tab-flash">You signed in with another tab or window. <a href="">Reload</a> to refresh your session.</span>
      <span class="signed-out-tab-flash">You signed out in another tab or window. <a href="">Reload</a> to refresh your session.</span>
    </div>
  </body>
</html>

