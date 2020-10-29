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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportTrendData : AbstractModel
    {
        
        /// <summary>
        /// 总次数
        /// </summary>
        [JsonProperty("TotalList")]
        public string[] TotalList{ get; set; }

        /// <summary>
        /// 被取消次数
        /// </summary>
        [JsonProperty("CancelList")]
        public string[] CancelList{ get; set; }

        /// <summary>
        /// 成功次数
        /// </summary>
        [JsonProperty("SuccessList")]
        public string[] SuccessList{ get; set; }

        /// <summary>
        /// 失败次数
        /// </summary>
        [JsonProperty("FailList")]
        public string[] FailList{ get; set; }

        /// <summary>
        /// 超时次数
        /// </summary>
        [JsonProperty("TimeoutList")]
        public string[] TimeoutList{ get; set; }

        /// <summary>
        /// 时间数组，单位：秒
        /// </summary>
        [JsonProperty("TimeList")]
        public string[] TimeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TotalList.", this.TotalList);
            this.SetParamArraySimple(map, prefix + "CancelList.", this.CancelList);
            this.SetParamArraySimple(map, prefix + "SuccessList.", this.SuccessList);
            this.SetParamArraySimple(map, prefix + "FailList.", this.FailList);
            this.SetParamArraySimple(map, prefix + "TimeoutList.", this.TimeoutList);
            this.SetParamArraySimple(map, prefix + "TimeList.", this.TimeList);
        }
    }
}

