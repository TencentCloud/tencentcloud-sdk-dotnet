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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsCampaignStatisticsTemplateData : AbstractModel
    {
        
        /// <summary>
        /// 模板或样例id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonProperty("TemplateContent")]
        public string TemplateContent{ get; set; }

        /// <summary>
        /// 触达成功数
        /// </summary>
        [JsonProperty("SendCount")]
        public ulong? SendCount{ get; set; }

        /// <summary>
        /// 短链点击数
        /// </summary>
        [JsonProperty("ClickCount")]
        public ulong? ClickCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateContent", this.TemplateContent);
            this.SetParamSimple(map, prefix + "SendCount", this.SendCount);
            this.SetParamSimple(map, prefix + "ClickCount", this.ClickCount);
        }
    }
}

