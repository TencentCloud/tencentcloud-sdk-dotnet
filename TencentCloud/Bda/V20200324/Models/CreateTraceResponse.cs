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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTraceResponse : AbstractModel
    {
        
        /// <summary>
        /// 人员动作轨迹唯一标识。
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// 人体识别所用的算法模型版本。
        /// </summary>
        [JsonProperty("BodyModelVersion")]
        public string BodyModelVersion{ get; set; }

        /// <summary>
        /// 输入的人体动作轨迹图片中的合法性校验结果。
        /// 只有为0时结果才有意义。
        /// -1001: 输入图片不合法。-1002: 输入图片不能构成轨迹。
        /// </summary>
        [JsonProperty("InputRetCode")]
        public long? InputRetCode{ get; set; }

        /// <summary>
        /// 输入的人体动作轨迹图片中的合法性校验结果详情。 
        /// -1101:图片无效，-1102:url不合法。-1103:图片过大。-1104:图片下载失败。-1105:图片解码失败。-1109:图片分辨率过高。-2023:动作轨迹中有非同人图片。-2024: 动作轨迹提取失败。-2025: 人体检测失败。
        /// </summary>
        [JsonProperty("InputRetCodeDetails")]
        public long?[] InputRetCodeDetails{ get; set; }

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
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamSimple(map, prefix + "BodyModelVersion", this.BodyModelVersion);
            this.SetParamSimple(map, prefix + "InputRetCode", this.InputRetCode);
            this.SetParamArraySimple(map, prefix + "InputRetCodeDetails.", this.InputRetCodeDetails);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

