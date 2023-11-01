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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadLogRequest : AbstractModel, IOctetRequest
    {
        
        /// <summary>
        /// 主题id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 根据 hashkey 写入相应范围的主题分区
        /// </summary>
        [JsonProperty("HashKey")]
        public string HashKey{ get; set; }

        /// <summary>
        /// 压缩方法
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        public byte[] OctetBody { get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "HashKey", this.HashKey);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

