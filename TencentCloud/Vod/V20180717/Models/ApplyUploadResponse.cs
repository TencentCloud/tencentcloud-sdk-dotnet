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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyUploadResponse : AbstractModel
    {
        
        /// <summary>
        /// 存储桶，用于上传接口 URL 的 bucket_name。
        /// </summary>
        [JsonProperty("StorageBucket")]
        public string StorageBucket{ get; set; }

        /// <summary>
        /// 存储园区，用于上传接口 Host 的 Region。
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// 点播会话，用于确认上传接口的参数 VodSessionKey。
        /// </summary>
        [JsonProperty("VodSessionKey")]
        public string VodSessionKey{ get; set; }

        /// <summary>
        /// 媒体存储路径，用于上传接口存储媒体的对象键（Key）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }

        /// <summary>
        /// 封面存储路径，用于上传接口存储封面的对象键（Key）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverStoragePath")]
        public string CoverStoragePath{ get; set; }

        /// <summary>
        /// 临时凭证，用于上传接口的权限验证。
        /// </summary>
        [JsonProperty("TempCertificate")]
        public TempCertificate TempCertificate{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageBucket", this.StorageBucket);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "VodSessionKey", this.VodSessionKey);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "CoverStoragePath", this.CoverStoragePath);
            this.SetParamObj(map, prefix + "TempCertificate.", this.TempCertificate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

