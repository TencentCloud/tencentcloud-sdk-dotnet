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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClsParam : AbstractModel
    {
        
        /// <summary>
        /// 生产的信息是否为json格式
        /// </summary>
        [JsonProperty("DecodeJson")]
        public bool? DecodeJson{ get; set; }

        /// <summary>
        /// cls日志主题id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// cls日志集id
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// 当DecodeJson为false时必填
        /// </summary>
        [JsonProperty("ContentKey")]
        public string ContentKey{ get; set; }

        /// <summary>
        /// 指定消息中的某字段内容作为cls日志的时间。
        /// 字段内容格式需要是秒级时间戳
        /// </summary>
        [JsonProperty("TimeField")]
        public string TimeField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DecodeJson", this.DecodeJson);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "ContentKey", this.ContentKey);
            this.SetParamSimple(map, prefix + "TimeField", this.TimeField);
        }
    }
}

