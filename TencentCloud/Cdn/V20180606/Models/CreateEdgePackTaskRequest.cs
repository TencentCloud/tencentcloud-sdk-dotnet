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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEdgePackTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// apk 所在的 cos 存储桶, 如 edgepack-xxxxxxxx
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// apk 源文件的存储路径, 如 /apk/xxxx.apk
        /// </summary>
        [JsonProperty("CosUriFrom")]
        public string CosUriFrom{ get; set; }

        /// <summary>
        /// BlockID 的值, WALLE为1903654775(0x71777777)，VasDolly为2282837503(0x881155ff),传0或不传时默认为 WALLE 方案
        /// </summary>
        [JsonProperty("BlockID")]
        public ulong? BlockID{ get; set; }

        /// <summary>
        /// 拓展之后的 apk 目标存储路径,如 /out/xxxx.apk
        /// </summary>
        [JsonProperty("CosUriTo")]
        public string CosUriTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosUriFrom", this.CosUriFrom);
            this.SetParamSimple(map, prefix + "BlockID", this.BlockID);
            this.SetParamSimple(map, prefix + "CosUriTo", this.CosUriTo);
        }
    }
}

