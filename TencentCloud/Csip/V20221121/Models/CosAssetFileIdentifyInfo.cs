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

    public class CosAssetFileIdentifyInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件路径</p>
        /// </summary>
        [JsonProperty("DirName")]
        public string DirName{ get; set; }

        /// <summary>
        /// <p>分类数据项详情</p>
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public CosIdentifyCategoryDetail[] CategoryDetails{ get; set; }

        /// <summary>
        /// <p>存储桶信息</p>
        /// </summary>
        [JsonProperty("BucketInfo")]
        public CosBucketInfo BucketInfo{ get; set; }

        /// <summary>
        /// <p>最后一次扫描时间</p>
        /// </summary>
        [JsonProperty("LastScanTime")]
        public ulong? LastScanTime{ get; set; }

        /// <summary>
        /// <p>处置状态</p>
        /// </summary>
        [JsonProperty("HandleStatus")]
        public ulong? HandleStatus{ get; set; }

        /// <summary>
        /// <p>结果唯一标识</p>
        /// </summary>
        [JsonProperty("ResultId")]
        public string ResultId{ get; set; }

        /// <summary>
        /// <p>规则详情</p>
        /// </summary>
        [JsonProperty("RuleDetails")]
        public CosIdentifyRuleDetail[] RuleDetails{ get; set; }

        /// <summary>
        /// <p>级别详情</p>
        /// </summary>
        [JsonProperty("LevelDetails")]
        public CosIdentifyLevelDetail[] LevelDetails{ get; set; }

        /// <summary>
        /// <p>模板ID</p>
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "DirName", this.DirName);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
            this.SetParamObj(map, prefix + "BucketInfo.", this.BucketInfo);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "ResultId", this.ResultId);
            this.SetParamArrayObj(map, prefix + "RuleDetails.", this.RuleDetails);
            this.SetParamArrayObj(map, prefix + "LevelDetails.", this.LevelDetails);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
        }
    }
}

