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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeConf : AbstractModel
    {
        
        /// <summary>
        /// 存储类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 对象存储桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 存储连接地址
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 存储连接用户密码
        /// </summary>
        [JsonProperty("KeyID")]
        public string KeyID{ get; set; }

        /// <summary>
        /// 存储挂载目的目录
        /// </summary>
        [JsonProperty("DstPath")]
        public string DstPath{ get; set; }

        /// <summary>
        /// 存储挂载源目录
        /// </summary>
        [JsonProperty("SrcPath")]
        public string SrcPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "KeyID", this.KeyID);
            this.SetParamSimple(map, prefix + "DstPath", this.DstPath);
            this.SetParamSimple(map, prefix + "SrcPath", this.SrcPath);
        }
    }
}

