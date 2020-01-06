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

namespace TencentCloud.Yunsou.V20180504.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataManipulationRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，add或del
        /// </summary>
        [JsonProperty("OpType")]
        public string OpType{ get; set; }

        /// <summary>
        /// 数据编码类型
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("Contents")]
        public string Contents{ get; set; }

        /// <summary>
        /// 应用Id
        /// </summary>
        [JsonProperty("ResourceId")]
        public ulong? ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "Contents", this.Contents);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

