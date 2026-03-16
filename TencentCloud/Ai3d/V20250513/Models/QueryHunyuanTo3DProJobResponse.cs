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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryHunyuanTo3DProJobResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务状态。WAIT：等待中，RUN：执行中，FAIL：任务失败，DONE：任务成功</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>错误码</p>
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>生成的3D文件数组。</p>
        /// </summary>
        [JsonProperty("ResultFile3Ds")]
        public File3D[] ResultFile3Ds{ get; set; }

        /// <summary>
        /// <p>接口任务功能参数及积分详情，返回形式为字符串。Generate参数返回对应模式及消耗积分，如：Generate-Normal：20<br>附加参数返回参数名称及消耗积分，如：MultiViewImages：10</p>
        /// </summary>
        [JsonProperty("ResultCreditDetails")]
        public string ResultCreditDetails{ get; set; }

        /// <summary>
        /// <p>任务总消耗积分。</p>
        /// </summary>
        [JsonProperty("ResultCreditConsumed")]
        public float? ResultCreditConsumed{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamArrayObj(map, prefix + "ResultFile3Ds.", this.ResultFile3Ds);
            this.SetParamSimple(map, prefix + "ResultCreditDetails", this.ResultCreditDetails);
            this.SetParamSimple(map, prefix + "ResultCreditConsumed", this.ResultCreditConsumed);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

