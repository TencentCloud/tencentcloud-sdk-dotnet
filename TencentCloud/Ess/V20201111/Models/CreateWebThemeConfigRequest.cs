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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWebThemeConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 主题类型
        /// <br/>EMBED_WEB_THEME：嵌入式主题
        /// <br/>目前只支持EMBED_WEB_THEME，web页面嵌入的主题风格配置
        /// </summary>
        [JsonProperty("ThemeType")]
        public string ThemeType{ get; set; }

        /// <summary>
        /// 主题配置
        /// </summary>
        [JsonProperty("WebThemeConfig")]
        public WebThemeConfig WebThemeConfig{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。	
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ThemeType", this.ThemeType);
            this.SetParamObj(map, prefix + "WebThemeConfig.", this.WebThemeConfig);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

