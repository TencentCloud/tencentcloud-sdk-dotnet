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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupFile : AbstractModel
    {
        
        /// <summary>
        /// 备份文件所属的副本集/分片id
        /// </summary>
        [JsonProperty("ReplicateSetId")]
        public string ReplicateSetId{ get; set; }

        /// <summary>
        /// 备份文件保存路径
        /// </summary>
        [JsonProperty("File")]
        public string File{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplicateSetId", this.ReplicateSetId);
            this.SetParamSimple(map, prefix + "File", this.File);
        }
    }
}

