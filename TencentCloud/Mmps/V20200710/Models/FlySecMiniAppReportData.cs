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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlySecMiniAppReportData : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskID")]
        public string TaskID{ get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [JsonProperty("MiniAppID")]
        public string MiniAppID{ get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("MiniAppName")]
        public string MiniAppName{ get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonProperty("MiniAppVersion")]
        public string MiniAppVersion{ get; set; }

        /// <summary>
        /// 诊断模式 1:基础诊断，2:深度诊断
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 诊断状态, 0:排队中, 1:成功, 2:失败, 3:进行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 诊断时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 诊断得分
        /// </summary>
        [JsonProperty("RiskScore")]
        public string RiskScore{ get; set; }

        /// <summary>
        /// 诊断风险等级 1:高风险 2:中风险 3:低风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 诊断8大维度得分情况(每项总分100分)
        /// </summary>
        [JsonProperty("RiskItems")]
        public FlySecMiniAppRiskItems RiskItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "MiniAppID", this.MiniAppID);
            this.SetParamSimple(map, prefix + "MiniAppName", this.MiniAppName);
            this.SetParamSimple(map, prefix + "MiniAppVersion", this.MiniAppVersion);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamObj(map, prefix + "RiskItems.", this.RiskItems);
        }
    }
}

