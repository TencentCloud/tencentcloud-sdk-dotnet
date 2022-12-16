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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterPrintConfig : AbstractModel
    {
        
        /// <summary>
        /// 水印偏移量，取值范围[0, 100)
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 是否开启，取值[
        /// 0（手动开启）
        /// 1（立即运行）
        /// ]
        /// </summary>
        [JsonProperty("OpenStatus")]
        public long? OpenStatus{ get; set; }

        /// <summary>
        /// 水印所属的转发监听器列表
        /// </summary>
        [JsonProperty("Listeners")]
        public ForwardListener[] Listeners{ get; set; }

        /// <summary>
        /// 水印添加成功后生成的水印密钥列表，一条水印最少1个密钥，最多2个密钥
        /// </summary>
        [JsonProperty("Keys")]
        public WaterPrintKey[] Keys{ get; set; }

        /// <summary>
        /// 水印检查模式, 取值[
        /// checkall（普通模式）
        /// shortfpcheckall（精简模式）
        /// ]
        /// </summary>
        [JsonProperty("Verify")]
        public string Verify{ get; set; }

        /// <summary>
        /// 是否开启代理，1开启则忽略IP+端口校验；0关闭则需要IP+端口校验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudSdkProxy")]
        public long? CloudSdkProxy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
            this.SetParamArrayObj(map, prefix + "Listeners.", this.Listeners);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "Verify", this.Verify);
            this.SetParamSimple(map, prefix + "CloudSdkProxy", this.CloudSdkProxy);
        }
    }
}

