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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PagerDutyRobotNoticeTmpl : AbstractModel
    {
        
        /// <summary>
        /// 请求体模板 仅支持json
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// 请求头 暂时未支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public PagerDutyRobotNoticeTmplHeader[] Headers{ get; set; }

        /// <summary>
        /// 标题模板
        /// </summary>
        [JsonProperty("TitleTmpl")]
        public string TitleTmpl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "TitleTmpl", this.TitleTmpl);
        }
    }
}

