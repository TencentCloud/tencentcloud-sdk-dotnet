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

    public class EDRExportJobItem : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>数据源</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>导出状态</p>
        /// </summary>
        [JsonProperty("ExportStatus")]
        public string ExportStatus{ get; set; }

        /// <summary>
        /// <p>导出进度</p>
        /// </summary>
        [JsonProperty("ExportProgress")]
        public long? ExportProgress{ get; set; }

        /// <summary>
        /// <p>失败信息</p>
        /// </summary>
        [JsonProperty("FailureMsg")]
        public string FailureMsg{ get; set; }

        /// <summary>
        /// <p>超时时间</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public string Timeout{ get; set; }

        /// <summary>
        /// <p>插入时间</p>
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ExportStatus", this.ExportStatus);
            this.SetParamSimple(map, prefix + "ExportProgress", this.ExportProgress);
            this.SetParamSimple(map, prefix + "FailureMsg", this.FailureMsg);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
        }
    }
}

