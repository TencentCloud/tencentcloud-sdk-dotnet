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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutEvaluationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 回调令牌。从自定义规则所选的scf云函数入参中取参数ResultToken值
        /// <a href="https://cloud.tencent.com/document/product/583/9210#.E5.87.BD.E6.95.B0.E5.85.A5.E5.8F.82.3Ca-id.3D.22input.22.3E.3C.2Fa.3E" target="_blank">云函数入参说明</a>
        /// </summary>
        [JsonProperty("ResultToken")]
        public string ResultToken{ get; set; }

        /// <summary>
        /// 自定义规则评估结果信息。
        /// </summary>
        [JsonProperty("Evaluations")]
        public Evaluation[] Evaluations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultToken", this.ResultToken);
            this.SetParamArrayObj(map, prefix + "Evaluations.", this.Evaluations);
        }
    }
}

