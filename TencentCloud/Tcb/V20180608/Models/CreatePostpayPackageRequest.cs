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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePostpayPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID，需要系统自动创建环境时，此字段不传
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 微信 AppId，微信必传
        /// </summary>
        [JsonProperty("WxAppId")]
        public string WxAppId{ get; set; }

        /// <summary>
        /// 付费来源
        /// <li>miniapp</li>
        /// <li>qcloud</li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 用户享有的免费额度级别，目前只能为“basic”，不传该字段或该字段为空，标识不享受免费额度。
        /// </summary>
        [JsonProperty("FreeQuota")]
        public string FreeQuota{ get; set; }

        /// <summary>
        /// 环境创建来源，取值：
        /// <li>miniapp</li>
        /// <li>qcloud</li>
        /// 用法同CreateEnv接口的Source参数
        /// 和 Channel 参数同时传，或者同时不传；EnvId 为空时必传。
        /// </summary>
        [JsonProperty("EnvSource")]
        public string EnvSource{ get; set; }

        /// <summary>
        /// 环境别名，要以a-z开头，不能包含  a-z,0-9,-  以外的字符
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 如果envsource为miniapp, channel可以为ide或api;
        /// 如果envsource为qcloud, channel可以为qc_console,cocos, qq, cloudgame,dcloud,serverless_framework
        /// 和 EnvSource 参数同时传，或者同时不传；EnvId 为空时必传。
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 扩展ID
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 订单标记。建议使用方统一转大小写之后再判断。
        /// <li>QuickStart：快速启动来源</li>
        /// <li>Activity：活动来源</li>
        /// </summary>
        [JsonProperty("Flag")]
        public string Flag{ get; set; }

        /// <summary>
        /// 环境别名，无字符类型限制
        /// </summary>
        [JsonProperty("EnvAlias")]
        public string EnvAlias{ get; set; }

        /// <summary>
        /// 附加字段，用于透传额外的自定义信息
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "WxAppId", this.WxAppId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "EnvSource", this.EnvSource);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "EnvAlias", this.EnvAlias);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

