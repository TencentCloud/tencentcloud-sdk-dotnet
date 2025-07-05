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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollingUpdateApplicationByVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 更新版本，IMAGE 部署为 tag 值；JAR/WAR 部署 为 Version
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// JAR/WAR 包名，仅 JAR/WAR 部署时必填
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 请求来源平台，含 IntelliJ，Coding
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 部署策略，AUTO 为全自动；BETA 为小批量验证后自动；MANUAL 为全手动；
        /// </summary>
        [JsonProperty("DeployStrategyType")]
        public string DeployStrategyType{ get; set; }

        /// <summary>
        /// 发布批次数
        /// </summary>
        [JsonProperty("TotalBatchCount")]
        public long? TotalBatchCount{ get; set; }

        /// <summary>
        /// 批次间隔时间
        /// </summary>
        [JsonProperty("BatchInterval")]
        public long? BatchInterval{ get; set; }

        /// <summary>
        /// 小批量验证批次的实例数
        /// </summary>
        [JsonProperty("BetaBatchNum")]
        public long? BetaBatchNum{ get; set; }

        /// <summary>
        /// 发布过程中保障的最小可用实例数
        /// </summary>
        [JsonProperty("MinAvailable")]
        public long? MinAvailable{ get; set; }

        /// <summary>
        /// 是否强制发布
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "DeployStrategyType", this.DeployStrategyType);
            this.SetParamSimple(map, prefix + "TotalBatchCount", this.TotalBatchCount);
            this.SetParamSimple(map, prefix + "BatchInterval", this.BatchInterval);
            this.SetParamSimple(map, prefix + "BetaBatchNum", this.BetaBatchNum);
            this.SetParamSimple(map, prefix + "MinAvailable", this.MinAvailable);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

