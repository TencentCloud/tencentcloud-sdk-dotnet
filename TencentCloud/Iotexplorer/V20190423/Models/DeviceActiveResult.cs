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

    public class DeviceActiveResult : AbstractModel
    {
        
        /// <summary>
        /// 模板ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelId")]
        [System.Obsolete]
        public string ModelId{ get; set; }

        /// <summary>
        /// SN信息
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 设备激活状态，0：激活成功；50011：系统错误；50012：产品不存在；50013：设备不存在；50014：产品无权限；50015：不是音视频产品；50016：SN格式错误；50017：激活码类型错误；50018：激活次数限频；50019：激活码不足；50020：SN已暂停；
        /// </summary>
        [JsonProperty("ErrCode")]
        public ulong? ErrCode{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

