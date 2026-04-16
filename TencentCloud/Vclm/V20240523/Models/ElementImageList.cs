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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ElementImageList : AbstractModel
    {
        
        /// <summary>
        /// <p>主体参考图</p>
        /// </summary>
        [JsonProperty("ReferImages")]
        public ReferImageItem[] ReferImages{ get; set; }

        /// <summary>
        /// <p>主体主图</p>
        /// </summary>
        [JsonProperty("FrontalImage")]
        public string FrontalImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ReferImages.", this.ReferImages);
            this.SetParamSimple(map, prefix + "FrontalImage", this.FrontalImage);
        }
    }
}

