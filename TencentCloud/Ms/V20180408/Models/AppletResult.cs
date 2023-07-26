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

    public class AppletResult : AbstractModel
    {
        
        /// <summary>
        /// 加固任务结果id
        /// </summary>
        [JsonProperty("ResultId")]
        public string ResultId{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 操作账号
        /// </summary>
        [JsonProperty("OpUin")]
        public long? OpUin{ get; set; }

        /// <summary>
        /// 加固结果
        /// </summary>
        [JsonProperty("EncryptState")]
        public long? EncryptState{ get; set; }

        /// <summary>
        /// 加固结果描述
        /// </summary>
        [JsonProperty("EncryptStateDesc")]
        public string EncryptStateDesc{ get; set; }

        /// <summary>
        /// 失败错误码
        /// </summary>
        [JsonProperty("EncryptErrCode")]
        public long? EncryptErrCode{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("EncryptErrDesc")]
        public string EncryptErrDesc{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("EncryptErrRef")]
        public string EncryptErrRef{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreatTime")]
        public string CreatTime{ get; set; }

        /// <summary>
        /// 任务开始处理时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务处理结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 加固耗时（秒单位）
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 在线加固成功下载包
        /// </summary>
        [JsonProperty("EncryptPkgUrl")]
        public string EncryptPkgUrl{ get; set; }

        /// <summary>
        /// 本次加固配置
        /// </summary>
        [JsonProperty("AppletInfo")]
        public AppletInfo AppletInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultId", this.ResultId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "OpUin", this.OpUin);
            this.SetParamSimple(map, prefix + "EncryptState", this.EncryptState);
            this.SetParamSimple(map, prefix + "EncryptStateDesc", this.EncryptStateDesc);
            this.SetParamSimple(map, prefix + "EncryptErrCode", this.EncryptErrCode);
            this.SetParamSimple(map, prefix + "EncryptErrDesc", this.EncryptErrDesc);
            this.SetParamSimple(map, prefix + "EncryptErrRef", this.EncryptErrRef);
            this.SetParamSimple(map, prefix + "CreatTime", this.CreatTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "EncryptPkgUrl", this.EncryptPkgUrl);
            this.SetParamObj(map, prefix + "AppletInfo.", this.AppletInfo);
        }
    }
}

