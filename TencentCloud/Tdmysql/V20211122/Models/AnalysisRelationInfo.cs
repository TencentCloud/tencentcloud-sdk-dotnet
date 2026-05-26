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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalysisRelationInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>源实例Id</p>
        /// </summary>
        [JsonProperty("PrimaryInstanceId")]
        public string PrimaryInstanceId{ get; set; }

        /// <summary>
        /// <p>分析引擎实例Id</p>
        /// </summary>
        [JsonProperty("AnalysisInstanceId")]
        public string AnalysisInstanceId{ get; set; }

        /// <summary>
        /// <p>分析引擎关系状态</p><p>枚举值：</p><ul><li>creating： 创建中</li><li>running： 运行中</li><li>destroyed： 已销毁</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrimaryInstanceId", this.PrimaryInstanceId);
            this.SetParamSimple(map, prefix + "AnalysisInstanceId", this.AnalysisInstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
        }
    }
}

