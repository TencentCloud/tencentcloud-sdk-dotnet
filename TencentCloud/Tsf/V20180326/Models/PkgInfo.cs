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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PkgInfo : AbstractModel
    {
        
        /// <summary>
        /// 程序包ID
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 程序包名
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// 程序包类型
        /// </summary>
        [JsonProperty("PkgType")]
        public string PkgType{ get; set; }

        /// <summary>
        /// 程序包版本
        /// </summary>
        [JsonProperty("PkgVersion")]
        public string PkgVersion{ get; set; }

        /// <summary>
        /// 程序包描述
        /// </summary>
        [JsonProperty("PkgDesc")]
        public string PkgDesc{ get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [JsonProperty("UploadTime")]
        public string UploadTime{ get; set; }

        /// <summary>
        /// 程序包MD5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 程序包状态
        /// </summary>
        [JsonProperty("PkgPubStatus")]
        public long? PkgPubStatus{ get; set; }

        /// <summary>
        /// 程序包关联关系
        /// </summary>
        [JsonProperty("PkgBindInfo")]
        public PkgBind[] PkgBindInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgName", this.PkgName);
            this.SetParamSimple(map, prefix + "PkgType", this.PkgType);
            this.SetParamSimple(map, prefix + "PkgVersion", this.PkgVersion);
            this.SetParamSimple(map, prefix + "PkgDesc", this.PkgDesc);
            this.SetParamSimple(map, prefix + "UploadTime", this.UploadTime);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "PkgPubStatus", this.PkgPubStatus);
            this.SetParamArrayObj(map, prefix + "PkgBindInfo.", this.PkgBindInfo);
        }
    }
}

