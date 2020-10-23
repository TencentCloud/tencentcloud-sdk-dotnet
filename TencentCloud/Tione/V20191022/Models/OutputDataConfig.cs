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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputDataConfig : AbstractModel
    {
        
        /// <summary>
        /// cos输出桶
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosOutputBucket")]
        public string CosOutputBucket{ get; set; }

        /// <summary>
        /// cos输出key前缀
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosOutputKeyPrefix")]
        public string CosOutputKeyPrefix{ get; set; }

        /// <summary>
        /// 文件系统输出，如果指定了文件系统，那么Cos输出会被忽略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSystemDataSource")]
        public FileSystemDataSource FileSystemDataSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosOutputBucket", this.CosOutputBucket);
            this.SetParamSimple(map, prefix + "CosOutputKeyPrefix", this.CosOutputKeyPrefix);
            this.SetParamObj(map, prefix + "FileSystemDataSource.", this.FileSystemDataSource);
        }
    }
}

