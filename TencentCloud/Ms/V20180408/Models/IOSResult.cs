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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IOSResult : AbstractModel
    {
        
        /// <summary>
        /// 加固任务结果Id
        /// </summary>
        [JsonProperty("ResultId")]
        public string ResultId{ get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonProperty("OpUin")]
        public long? OpUin{ get; set; }

        /// <summary>
        /// 加固类型，这里为ios
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 加固状态：0等待，1成功，2任务中，3失败，4重试中
        /// </summary>
        [JsonProperty("EncryptState")]
        public long? EncryptState{ get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonProperty("EncryptErrno")]
        public long? EncryptErrno{ get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [JsonProperty("EncryptErrDesc")]
        public string EncryptErrDesc{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatTime")]
        public string CreatTime{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 消耗时间
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 加固（混淆）包结果url
        /// </summary>
        [JsonProperty("EncryptPkgUrl")]
        public string EncryptPkgUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultId", this.ResultId);
            this.SetParamSimple(map, prefix + "OpUin", this.OpUin);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "EncryptState", this.EncryptState);
            this.SetParamSimple(map, prefix + "EncryptErrno", this.EncryptErrno);
            this.SetParamSimple(map, prefix + "EncryptErrDesc", this.EncryptErrDesc);
            this.SetParamSimple(map, prefix + "CreatTime", this.CreatTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "EncryptPkgUrl", this.EncryptPkgUrl);
        }
    }
}

