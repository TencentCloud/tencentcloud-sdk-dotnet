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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileSystemInfo : AbstractModel
    {
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 用户自定义名称
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// 文件系统 ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统状态
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// 文件系统已使用容量
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// 文件系统最大空间限制
        /// </summary>
        [JsonProperty("SizeLimit")]
        public ulong? SizeLimit{ get; set; }

        /// <summary>
        /// 区域 ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 文件系统协议类型
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 文件系统存储类型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 文件系统绑定的预付费存储包（暂未支持）
        /// </summary>
        [JsonProperty("StorageResourcePkg")]
        public string StorageResourcePkg{ get; set; }

        /// <summary>
        /// 文件系统绑定的预付费带宽包（暂未支持）
        /// </summary>
        [JsonProperty("BandwidthResourcePkg")]
        public string BandwidthResourcePkg{ get; set; }

        /// <summary>
        /// 文件系统绑定权限组信息
        /// </summary>
        [JsonProperty("PGroup")]
        public PGroup PGroup{ get; set; }

        /// <summary>
        /// 用户自定义名称
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// 文件系统是否加密
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// 加密所使用的密钥，可以为密钥的 ID 或者 ARN
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "SizeLimit", this.SizeLimit);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageResourcePkg", this.StorageResourcePkg);
            this.SetParamSimple(map, prefix + "BandwidthResourcePkg", this.BandwidthResourcePkg);
            this.SetParamObj(map, prefix + "PGroup.", this.PGroup);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

