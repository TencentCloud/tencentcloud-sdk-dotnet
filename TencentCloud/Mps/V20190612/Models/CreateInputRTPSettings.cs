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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInputRTPSettings : AbstractModel
    {
        
        /// <summary>
        /// 默认为“none”，可选值['none']。
        /// </summary>
        [JsonProperty("FEC")]
        public string FEC{ get; set; }

        /// <summary>
        /// 空闲超时时间，默认5000，单位ms，范围为[1000, 10000]。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public long? IdleTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FEC", this.FEC);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
        }
    }
}

