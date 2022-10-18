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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageTransferOutInfo : AbstractModel
    {
        
        /// <summary>
        /// 权益包ID。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 转移码。
        /// </summary>
        [JsonProperty("TransferCode")]
        public string TransferCode{ get; set; }

        /// <summary>
        /// 本次转移点数。
        /// </summary>
        [JsonProperty("TransferCount")]
        public ulong? TransferCount{ get; set; }

        /// <summary>
        /// 转入的PackageID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceivePackageId")]
        public string ReceivePackageId{ get; set; }

        /// <summary>
        /// 本次转移过期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 本次转移生成时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 本次转移更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 转移状态。
        /// </summary>
        [JsonProperty("TransferStatus")]
        public string TransferStatus{ get; set; }

        /// <summary>
        /// 接收者uin。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverUin")]
        public ulong? ReceiverUin{ get; set; }

        /// <summary>
        /// 接收时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiveTime")]
        public string ReceiveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "TransferCode", this.TransferCode);
            this.SetParamSimple(map, prefix + "TransferCount", this.TransferCount);
            this.SetParamSimple(map, prefix + "ReceivePackageId", this.ReceivePackageId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TransferStatus", this.TransferStatus);
            this.SetParamSimple(map, prefix + "ReceiverUin", this.ReceiverUin);
            this.SetParamSimple(map, prefix + "ReceiveTime", this.ReceiveTime);
        }
    }
}

