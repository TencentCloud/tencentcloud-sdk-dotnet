/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebhookReceiverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>机器人名称<br>入参限制：长度 1-20 个字符，租户内唯一</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>机器人类型<br>枚举值：<br>WEBHOOK：webhook 类型<br>SCF：云函数类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>机器人 ID。大于 0 表示修改已有记录；等于 0 或不传表示新增<br>默认值：0</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Webhook 地址<br>入参限制：Type=WEBHOOK 时必填，长度 1-2048，必须为合法 http(s) URL，且不允许内网地址</p>
        /// </summary>
        [JsonProperty("WebhookAddr")]
        public string WebhookAddr{ get; set; }

        /// <summary>
        /// <p>云函数地域，例如 ap-guangzhou<br>入参限制：Type=SCF 时必填</p>
        /// </summary>
        [JsonProperty("SCFRegion")]
        public string SCFRegion{ get; set; }

        /// <summary>
        /// <p>云函数命名空间<br>入参限制：Type=SCF 时必填<br>取值参考：通过 DescribeSCFNamespaceList 接口获取</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>云函数名称<br>入参限制：Type=SCF 时必填<br>取值参考：通过 DescribeSCFFunctionList 接口获取</p>
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// <p>云函数版本<br>入参限制：Type=SCF 时必填，例如 $LATEST<br>取值参考：通过 DescribeSCFFunctionVersionList 接口获取</p>
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// <p>云函数别名<br>入参限制：Type=SCF 时必填，例如 $DEFAULT<br>取值参考：通过 DescribeSCFAliasList 接口获取</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "WebhookAddr", this.WebhookAddr);
            this.SetParamSimple(map, prefix + "SCFRegion", this.SCFRegion);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}

