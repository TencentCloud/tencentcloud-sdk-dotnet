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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveCodeDetail : AbstractModel
    {
        
        /// <summary>
        /// 活码id
        /// </summary>
        [JsonProperty("LiveCodeId")]
        public ulong? LiveCodeId{ get; set; }

        /// <summary>
        /// 活码名称
        /// </summary>
        [JsonProperty("LiveCodeName")]
        public string LiveCodeName{ get; set; }

        /// <summary>
        /// 短链url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShortChainAddress")]
        public string ShortChainAddress{ get; set; }

        /// <summary>
        /// 活码二维码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveCodePreview")]
        public string LiveCodePreview{ get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonProperty("ActivityName")]
        public string ActivityName{ get; set; }

        /// <summary>
        /// 活码状态，-1：删除，0：启用，1禁用，默认为0
        /// </summary>
        [JsonProperty("LiveCodeState")]
        public long? LiveCodeState{ get; set; }

        /// <summary>
        /// 活码参数，每个活码参数都是不一样的， 这个的值对应的是字符串json类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveCodeData")]
        public string LiveCodeData{ get; set; }

        /// <summary>
        /// 创建时间戳，单位为秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间戳，单位为秒
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LiveCodeId", this.LiveCodeId);
            this.SetParamSimple(map, prefix + "LiveCodeName", this.LiveCodeName);
            this.SetParamSimple(map, prefix + "ShortChainAddress", this.ShortChainAddress);
            this.SetParamSimple(map, prefix + "LiveCodePreview", this.LiveCodePreview);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityName", this.ActivityName);
            this.SetParamSimple(map, prefix + "LiveCodeState", this.LiveCodeState);
            this.SetParamSimple(map, prefix + "LiveCodeData", this.LiveCodeData);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

