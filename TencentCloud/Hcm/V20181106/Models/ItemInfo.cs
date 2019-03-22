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

namespace TencentCloud.Hcm.V20181106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemInfo : AbstractModel
    {
        
        /// <summary>
        /// 识别的算式是否正确
        /// </summary>
        [JsonProperty("Item")]
        public string Item{ get; set; }

        /// <summary>
        /// 识别的算式
        /// </summary>
        [JsonProperty("ItemString")]
        public string ItemString{ get; set; }

        /// <summary>
        /// 识别的算式在图片上的位置信息
        /// </summary>
        [JsonProperty("ItemCoord")]
        public ItemCoord ItemCoord{ get; set; }

        /// <summary>
        /// 推荐的答案
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Item", this.Item);
            this.SetParamSimple(map, prefix + "ItemString", this.ItemString);
            this.SetParamObj(map, prefix + "ItemCoord.", this.ItemCoord);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
        }
    }
}

