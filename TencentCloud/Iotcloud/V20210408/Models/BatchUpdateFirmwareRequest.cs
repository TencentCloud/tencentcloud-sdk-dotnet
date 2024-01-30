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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchUpdateFirmwareRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 固件新版本号
        /// </summary>
        [JsonProperty("FirmwareVersion")]
        public string FirmwareVersion{ get; set; }

        /// <summary>
        /// 固件原版本号，根据文件列表升级固件不需要填写此参数
        /// </summary>
        [JsonProperty("FirmwareOriVersion")]
        public string FirmwareOriVersion{ get; set; }

        /// <summary>
        /// 升级方式，0 静默升级  1 用户确认升级。 不填默认为静默升级方式
        /// </summary>
        [JsonProperty("UpgradeMethod")]
        public ulong? UpgradeMethod{ get; set; }

        /// <summary>
        /// 设备列表文件名称，根据文件列表升级固件需要填写此参数
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 设备列表的文件md5值
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 设备列表的文件大小值
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 需要升级的设备名称列表
        /// </summary>
        [JsonProperty("DeviceNames")]
        public string[] DeviceNames{ get; set; }

        /// <summary>
        /// 固件升级任务，默认超时时间。 最小取值60秒，最大为3600秒
        /// </summary>
        [JsonProperty("TimeoutInterval")]
        public ulong? TimeoutInterval{ get; set; }

        /// <summary>
        /// 固件升级任务类型，默认静态升级值为空或1，动态升级值为7。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "FirmwareVersion", this.FirmwareVersion);
            this.SetParamSimple(map, prefix + "FirmwareOriVersion", this.FirmwareOriVersion);
            this.SetParamSimple(map, prefix + "UpgradeMethod", this.UpgradeMethod);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamArraySimple(map, prefix + "DeviceNames.", this.DeviceNames);
            this.SetParamSimple(map, prefix + "TimeoutInterval", this.TimeoutInterval);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

