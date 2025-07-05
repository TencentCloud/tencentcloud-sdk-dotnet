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

    public class DescribeFlySecMiniAppReportUrlRequest : AbstractModel
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
        /// 诊断方式 1:基础诊断，2:深度诊断
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 诊断报告类型 0:基础诊断报告，1:总裁版诊断报告，2:诊断报告json结果
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "MiniAppID", this.MiniAppID);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
        }
    }
}

