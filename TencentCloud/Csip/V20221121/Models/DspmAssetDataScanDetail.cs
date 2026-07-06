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

    public class DspmAssetDataScanDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>识别任务状态 0:未识别 1:识别中 2:识别终止 3:识别成功 4:识别失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>识别任务状态 0:未识别 1:识别中 2:识别终止 3:识别成功 4:识别失败</p>
        /// </summary>
        [JsonProperty("StatusInfo")]
        public string StatusInfo{ get; set; }

        /// <summary>
        /// <p>识别进度</p>
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// <p>最近扫描时间</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>识别失败信息</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// <p>数据库数量</p>
        /// </summary>
        [JsonProperty("DbCount")]
        public ulong? DbCount{ get; set; }

        /// <summary>
        /// <p>分类id集合</p>
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }

        /// <summary>
        /// <p>分类名称集合</p>
        /// </summary>
        [JsonProperty("CategoryNames")]
        public string[] CategoryNames{ get; set; }

        /// <summary>
        /// <p>扫描任务配置</p>
        /// </summary>
        [JsonProperty("TaskConfig")]
        public DspmSensitiveScanTaskConfig TaskConfig{ get; set; }

        /// <summary>
        /// <p>识别结果分类详情</p>
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public DspmIdentifyCategoryDetail[] CategoryDetails{ get; set; }

        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusInfo", this.StatusInfo);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "DbCount", this.DbCount);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamArraySimple(map, prefix + "CategoryNames.", this.CategoryNames);
            this.SetParamObj(map, prefix + "TaskConfig.", this.TaskConfig);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

