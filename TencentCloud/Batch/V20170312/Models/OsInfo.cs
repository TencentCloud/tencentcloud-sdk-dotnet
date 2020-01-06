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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OsInfo : AbstractModel
    {
        
        /// <summary>
        /// 操作系统ID。
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }

        /// <summary>
        /// 操作系统名称。
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 操作系统名称描述。
        /// </summary>
        [JsonProperty("OsDescription")]
        public string OsDescription{ get; set; }

        /// <summary>
        /// 操作系统英文名称。
        /// </summary>
        [JsonProperty("OsEnglishDescription")]
        public string OsEnglishDescription{ get; set; }

        /// <summary>
        /// 操作系统的分类，如CentOs Debian。
        /// </summary>
        [JsonProperty("OsClass")]
        public string OsClass{ get; set; }

        /// <summary>
        /// 标识镜像分类。public:公共镜像; private: 专属镜像。
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// 操作系统，ext4文件下所支持的最大的磁盘大小。单位为T。
        /// </summary>
        [JsonProperty("MaxPartitionSize")]
        public ulong? MaxPartitionSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "OsDescription", this.OsDescription);
            this.SetParamSimple(map, prefix + "OsEnglishDescription", this.OsEnglishDescription);
            this.SetParamSimple(map, prefix + "OsClass", this.OsClass);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "MaxPartitionSize", this.MaxPartitionSize);
        }
    }
}

