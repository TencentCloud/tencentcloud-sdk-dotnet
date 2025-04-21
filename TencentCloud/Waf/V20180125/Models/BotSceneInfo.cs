/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotSceneInfo : AbstractModel
    {
        
        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 场景类型，default:默认场景,custom:非默认场景
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 场景名
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 场景模板类型，登录: login  秒杀:seckill  爬内容：crawl 自定义: custom
        /// </summary>
        [JsonProperty("BusinessType")]
        public string[] BusinessType{ get; set; }

        /// <summary>
        /// 客户端类型，浏览器/H5 : browser  小程序: miniApp  App:
        /// </summary>
        [JsonProperty("ClientType")]
        public string[] ClientType{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 匹配范围
        /// </summary>
        [JsonProperty("MatchCondition")]
        public BotSceneMatchCondition[] MatchCondition{ get; set; }

        /// <summary>
        /// 场景开关
        /// </summary>
        [JsonProperty("SceneStatus")]
        public bool? SceneStatus{ get; set; }

        /// <summary>
        /// 前端对抗开关
        /// </summary>
        [JsonProperty("JsInjectStatus")]
        public bool? JsInjectStatus{ get; set; }

        /// <summary>
        /// AI开关
        /// </summary>
        [JsonProperty("AIStatus")]
        public bool? AIStatus{ get; set; }

        /// <summary>
        /// TI开关
        /// </summary>
        [JsonProperty("TIStatus")]
        public bool? TIStatus{ get; set; }

        /// <summary>
        /// 智能统计开关
        /// </summary>
        [JsonProperty("StatisticStatus")]
        public bool? StatisticStatus{ get; set; }

        /// <summary>
        /// 动作策略数量
        /// </summary>
        [JsonProperty("ActionRuleCount")]
        public long? ActionRuleCount{ get; set; }

        /// <summary>
        /// 自定义规则数量
        /// </summary>
        [JsonProperty("UCBCount")]
        public long? UCBCount{ get; set; }

        /// <summary>
        /// 场景的匹配范围，global-全部匹配 custom-自定义匹配范围
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 匹配条件间的与或关系
        /// </summary>
        [JsonProperty("ActionMatchType")]
        public string ActionMatchType{ get; set; }

        /// <summary>
        /// UA模块开关
        /// </summary>
        [JsonProperty("UAStatus")]
        public bool? UAStatus{ get; set; }

        /// <summary>
        /// 简易模式场景：前端对抗对应mysql的记录id
        /// </summary>
        [JsonProperty("JsInjectRuleId")]
        public long? JsInjectRuleId{ get; set; }

        /// <summary>
        /// 简易模式场景：前端对抗配置动作
        /// </summary>
        [JsonProperty("JsInjectAction")]
        public long? JsInjectAction{ get; set; }

        /// <summary>
        /// 简易模式场景：前端对抗重定向路径
        /// </summary>
        [JsonProperty("JsInjectRedirect")]
        public string JsInjectRedirect{ get; set; }

        /// <summary>
        /// 简易模式场景：动作策略信息  PS:简易模式只有一个动作策略
        /// </summary>
        [JsonProperty("ActionRuleList")]
        public BotSceneActionRule[] ActionRuleList{ get; set; }

        /// <summary>
        /// 简易模式场景：monitor-观察 intercept-拦截 custom-自定义
        /// </summary>
        [JsonProperty("BotIdPattern")]
        public string BotIdPattern{ get; set; }

        /// <summary>
        /// 简易模式场景：bot_id规则总数
        /// </summary>
        [JsonProperty("BotIdCount")]
        public long? BotIdCount{ get; set; }

        /// <summary>
        /// 简易模式场景：观察动作的规则总数
        /// </summary>
        [JsonProperty("BotIdMonitorCount")]
        public long? BotIdMonitorCount{ get; set; }

        /// <summary>
        /// 简易模式场景：拦截动作的规则总数
        /// </summary>
        [JsonProperty("BotIdInterceptCount")]
        public long? BotIdInterceptCount{ get; set; }

        /// <summary>
        /// 创建场景时选择的规则集
        /// </summary>
        [JsonProperty("RuleSetSelection")]
        public string[] RuleSetSelection{ get; set; }

        /// <summary>
        /// 改场景的bot token列表
        /// </summary>
        [JsonProperty("TokenList")]
        public BotToken[] TokenList{ get; set; }

        /// <summary>
        /// 简易模式场景：重定向动作的规则总数
        /// </summary>
        [JsonProperty("BotIdRedirectCount")]
        public long? BotIdRedirectCount{ get; set; }

        /// <summary>
        /// 简易模式场景：人机识别动作的规则总数
        /// </summary>
        [JsonProperty("BotIdCaptchaCount")]
        public long? BotIdCaptchaCount{ get; set; }

        /// <summary>
        /// 简易模式场景：防护等级
        /// </summary>
        [JsonProperty("BotIdProtectLevel")]
        public string BotIdProtectLevel{ get; set; }

        /// <summary>
        /// 简易模式场景：全局重定向路径
        /// </summary>
        [JsonProperty("BotIdGlobalRedirect")]
        public string BotIdGlobalRedirect{ get; set; }

        /// <summary>
        /// 简易模式场景：JS校验动作的规则总数
        /// </summary>
        [JsonProperty("BotIdJsChallengeCount")]
        public long? BotIdJsChallengeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "BusinessType.", this.BusinessType);
            this.SetParamArraySimple(map, prefix + "ClientType.", this.ClientType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "MatchCondition.", this.MatchCondition);
            this.SetParamSimple(map, prefix + "SceneStatus", this.SceneStatus);
            this.SetParamSimple(map, prefix + "JsInjectStatus", this.JsInjectStatus);
            this.SetParamSimple(map, prefix + "AIStatus", this.AIStatus);
            this.SetParamSimple(map, prefix + "TIStatus", this.TIStatus);
            this.SetParamSimple(map, prefix + "StatisticStatus", this.StatisticStatus);
            this.SetParamSimple(map, prefix + "ActionRuleCount", this.ActionRuleCount);
            this.SetParamSimple(map, prefix + "UCBCount", this.UCBCount);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "ActionMatchType", this.ActionMatchType);
            this.SetParamSimple(map, prefix + "UAStatus", this.UAStatus);
            this.SetParamSimple(map, prefix + "JsInjectRuleId", this.JsInjectRuleId);
            this.SetParamSimple(map, prefix + "JsInjectAction", this.JsInjectAction);
            this.SetParamSimple(map, prefix + "JsInjectRedirect", this.JsInjectRedirect);
            this.SetParamArrayObj(map, prefix + "ActionRuleList.", this.ActionRuleList);
            this.SetParamSimple(map, prefix + "BotIdPattern", this.BotIdPattern);
            this.SetParamSimple(map, prefix + "BotIdCount", this.BotIdCount);
            this.SetParamSimple(map, prefix + "BotIdMonitorCount", this.BotIdMonitorCount);
            this.SetParamSimple(map, prefix + "BotIdInterceptCount", this.BotIdInterceptCount);
            this.SetParamArraySimple(map, prefix + "RuleSetSelection.", this.RuleSetSelection);
            this.SetParamArrayObj(map, prefix + "TokenList.", this.TokenList);
            this.SetParamSimple(map, prefix + "BotIdRedirectCount", this.BotIdRedirectCount);
            this.SetParamSimple(map, prefix + "BotIdCaptchaCount", this.BotIdCaptchaCount);
            this.SetParamSimple(map, prefix + "BotIdProtectLevel", this.BotIdProtectLevel);
            this.SetParamSimple(map, prefix + "BotIdGlobalRedirect", this.BotIdGlobalRedirect);
            this.SetParamSimple(map, prefix + "BotIdJsChallengeCount", this.BotIdJsChallengeCount);
        }
    }
}

