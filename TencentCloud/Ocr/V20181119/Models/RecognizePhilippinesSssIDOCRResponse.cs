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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizePhilippinesSssIDOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 人像照片Base64后的结果
        /// </summary>
        [JsonProperty("HeadPortrait")]
        public TextDetectionResult HeadPortrait{ get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public TextDetectionResult LicenseNumber{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("FullName")]
        public TextDetectionResult FullName{ get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("Birthday")]
        public TextDetectionResult Birthday{ get; set; }

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
            this.SetParamObj(map, prefix + "HeadPortrait.", this.HeadPortrait);
            this.SetParamObj(map, prefix + "LicenseNumber.", this.LicenseNumber);
            this.SetParamObj(map, prefix + "FullName.", this.FullName);
            this.SetParamObj(map, prefix + "Birthday.", this.Birthday);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

