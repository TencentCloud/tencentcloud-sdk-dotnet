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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileObject : AbstractModel
    {
        
        /// <summary>
        /// 文件标识符，可在各个API中引用。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 对象类型，始终为 file。
        /// </summary>
        [JsonProperty("Object")]
        public string Object{ get; set; }

        /// <summary>
        /// 文件大小，单位为字节。
        /// </summary>
        [JsonProperty("Bytes")]
        public ulong? Bytes{ get; set; }

        /// <summary>
        /// 文件创建时的 Unix 时间戳（秒）。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 文件名。
        /// </summary>
        [JsonProperty("Filename")]
        public string Filename{ get; set; }

        /// <summary>
        /// 上传文件的用途。
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Object", this.Object);
            this.SetParamSimple(map, prefix + "Bytes", this.Bytes);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "Filename", this.Filename);
            this.SetParamSimple(map, prefix + "Purpose", this.Purpose);
        }
    }
}

