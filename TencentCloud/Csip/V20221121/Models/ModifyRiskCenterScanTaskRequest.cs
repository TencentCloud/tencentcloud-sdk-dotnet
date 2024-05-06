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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRiskCenterScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 0-全扫，1-指定资产扫，2-排除资产扫，3-手动填写扫；1和2则Assets字段必填，3则SelfDefiningAssets必填
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// 扫描项目；port/poc/weakpass/webcontent/configrisk
        /// </summary>
        [JsonProperty("ScanItem")]
        public string[] ScanItem{ get; set; }

        /// <summary>
        /// 0-周期任务,1-立即扫描,2-定时扫描,3-自定义；0,2,3则ScanPlanContent必填
        /// </summary>
        [JsonProperty("ScanPlanType")]
        public long? ScanPlanType{ get; set; }

        /// <summary>
        /// 要修改的任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 扫描资产信息列表
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// 扫描计划详情
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// ip/域名/url数组
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// 高级配置
        /// </summary>
        [JsonProperty("TaskAdvanceCFG")]
        public TaskAdvanceCFG TaskAdvanceCFG{ get; set; }

        /// <summary>
        /// 体检模式，0-标准模式，1-快速模式，2-高级模式，默认标准模式
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ScanAssetType", this.ScanAssetType);
            this.SetParamArraySimple(map, prefix + "ScanItem.", this.ScanItem);
            this.SetParamSimple(map, prefix + "ScanPlanType", this.ScanPlanType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Assets.", this.Assets);
            this.SetParamSimple(map, prefix + "ScanPlanContent", this.ScanPlanContent);
            this.SetParamArraySimple(map, prefix + "SelfDefiningAssets.", this.SelfDefiningAssets);
            this.SetParamObj(map, prefix + "TaskAdvanceCFG.", this.TaskAdvanceCFG);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
        }
    }
}

