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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadFirmwareRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductID")]
        public string ProductID{ get; set; }

        /// <summary>
        /// 固件版本号
        /// </summary>
        [JsonProperty("FirmwareVersion")]
        public string FirmwareVersion{ get; set; }

        /// <summary>
        /// 固件的MD5值
        /// </summary>
        [JsonProperty("Md5sum")]
        public string Md5sum{ get; set; }

        /// <summary>
        /// 固件的大小
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 固件名称
        /// </summary>
        [JsonProperty("FirmwareName")]
        public string FirmwareName{ get; set; }

        /// <summary>
        /// 固件描述
        /// </summary>
        [JsonProperty("FirmwareDescription")]
        public string FirmwareDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamSimple(map, prefix + "FirmwareVersion", this.FirmwareVersion);
            this.SetParamSimple(map, prefix + "Md5sum", this.Md5sum);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FirmwareName", this.FirmwareName);
            this.SetParamSimple(map, prefix + "FirmwareDescription", this.FirmwareDescription);
        }
    }
}

