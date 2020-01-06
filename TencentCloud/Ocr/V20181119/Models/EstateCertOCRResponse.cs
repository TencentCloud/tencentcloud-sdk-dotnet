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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EstateCertOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 权利人
        /// </summary>
        [JsonProperty("Obligee")]
        public string Obligee{ get; set; }

        /// <summary>
        /// 共有情况
        /// </summary>
        [JsonProperty("Ownership")]
        public string Ownership{ get; set; }

        /// <summary>
        /// 坐落
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 不动产单元号
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 权利类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 权利性质
        /// </summary>
        [JsonProperty("Property")]
        public string Property{ get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// 面积
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 使用期限
        /// </summary>
        [JsonProperty("Term")]
        public string Term{ get; set; }

        /// <summary>
        /// 权利其他状况，多行会用换行符\n连接。
        /// </summary>
        [JsonProperty("Other")]
        public string Other{ get; set; }

        /// <summary>
        /// 图片旋转角度
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 不动产权号
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Obligee", this.Obligee);
            this.SetParamSimple(map, prefix + "Ownership", this.Ownership);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Property", this.Property);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Term", this.Term);
            this.SetParamSimple(map, prefix + "Other", this.Other);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

