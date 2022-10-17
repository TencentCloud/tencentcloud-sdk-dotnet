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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateReflectSequenceRequest : AbstractModel
    {
        
        /// <summary>
        /// SDK生成的打包数据的资源链接。
        /// </summary>
        [JsonProperty("DeviceDataUrl")]
        public string DeviceDataUrl{ get; set; }

        /// <summary>
        /// SDK生成的打包数据的MD5值。
        /// </summary>
        [JsonProperty("DeviceDataMd5")]
        public string DeviceDataMd5{ get; set; }

        /// <summary>
        /// 1-静默
        /// 2-眨眼
        /// 3-光线
        /// 4-眨眼+光线 （默认）
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public string SecurityLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceDataUrl", this.DeviceDataUrl);
            this.SetParamSimple(map, prefix + "DeviceDataMd5", this.DeviceDataMd5);
            this.SetParamSimple(map, prefix + "SecurityLevel", this.SecurityLevel);
        }
    }
}

