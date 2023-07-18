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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefererRule : AbstractModel
    {
        
        /// <summary>
        /// 规则类型：
        /// all：所有文件生效
        /// file：指定文件后缀生效
        /// directory：指定路径生效
        /// path：指定绝对路径生效
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// RuleType 对应类型下的匹配内容：
        /// all 时填充 *
        /// file 时填充后缀名，如 jpg、txt
        /// directory 时填充路径，如 /xxx/test/
        /// path 时填充绝对路径，如 /xxx/test.html
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// referer 配置类型
        /// whitelist：白名单
        /// blacklist：黑名单
        /// </summary>
        [JsonProperty("RefererType")]
        public string RefererType{ get; set; }

        /// <summary>
        /// referer 内容列表
        /// </summary>
        [JsonProperty("Referers")]
        public string[] Referers{ get; set; }

        /// <summary>
        /// 是否允许空 referer
        /// 防盗链类型为白名单时，true表示允许空 referer，false表示不允许空 referer；
        /// 防盗链类型为黑名单时，true表示拒绝空referer，false表示不拒绝空referer；
        /// </summary>
        [JsonProperty("AllowEmpty")]
        public bool? AllowEmpty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RefererType", this.RefererType);
            this.SetParamArraySimple(map, prefix + "Referers.", this.Referers);
            this.SetParamSimple(map, prefix + "AllowEmpty", this.AllowEmpty);
        }
    }
}

