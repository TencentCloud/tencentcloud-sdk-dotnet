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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFenceBindRequest : AbstractModel
    {
        
        /// <summary>
        /// 围栏Id
        /// </summary>
        [JsonProperty("FenceId")]
        public long? FenceId{ get; set; }

        /// <summary>
        /// 围栏绑定的产品列表
        /// </summary>
        [JsonProperty("Items")]
        public FenceBindProductItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FenceId", this.FenceId);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

