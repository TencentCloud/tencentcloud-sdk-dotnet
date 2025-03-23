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

    public class DropCls : AbstractModel
    {
        
        /// <summary>
        /// 是否投递到cls
        /// </summary>
        [JsonProperty("DropInvalidMessageToCls")]
        public bool? DropInvalidMessageToCls{ get; set; }

        /// <summary>
        /// 投递cls的地域
        /// </summary>
        [JsonProperty("DropClsRegion")]
        public string DropClsRegion{ get; set; }

        /// <summary>
        /// 投递cls的账号
        /// </summary>
        [JsonProperty("DropClsOwneruin")]
        public string DropClsOwneruin{ get; set; }

        /// <summary>
        /// 投递cls的主题
        /// </summary>
        [JsonProperty("DropClsTopicId")]
        public string DropClsTopicId{ get; set; }

        /// <summary>
        /// 投递cls的日志集id
        /// </summary>
        [JsonProperty("DropClsLogSet")]
        public string DropClsLogSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropInvalidMessageToCls", this.DropInvalidMessageToCls);
            this.SetParamSimple(map, prefix + "DropClsRegion", this.DropClsRegion);
            this.SetParamSimple(map, prefix + "DropClsOwneruin", this.DropClsOwneruin);
            this.SetParamSimple(map, prefix + "DropClsTopicId", this.DropClsTopicId);
            this.SetParamSimple(map, prefix + "DropClsLogSet", this.DropClsLogSet);
        }
    }
}

