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

    public class Orders : AbstractModel
    {
        
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 平台类型整型值 
        /// </summary>
        [JsonProperty("PlatformType")]
        public long? PlatformType{ get; set; }

        /// <summary>
        /// 平台类型描述：  1.android安卓加固   2.ios源码混淆  3.sdk加固  4.applet小程序加固
        /// </summary>
        [JsonProperty("PlatformTypeDesc")]
        public string PlatformTypeDesc{ get; set; }

        /// <summary>
        /// 订单采购类型整型值
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 订单采购类型描述： 1-免费试用 2-按年收费 3-按次收费
        /// </summary>
        [JsonProperty("OrderTypeDesc")]
        public string OrderTypeDesc{ get; set; }

        /// <summary>
        /// 安卓包年收费加固的包名
        /// </summary>
        [JsonProperty("AppPkgName")]
        public string AppPkgName{ get; set; }

        /// <summary>
        /// 资源号
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源状态整型值
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public long? ResourceStatus{ get; set; }

        /// <summary>
        /// 资源状态描述
        /// 0-未生效、1-生效中、2-已失效。
        /// </summary>
        [JsonProperty("ResourceStatusDesc")]
        public string ResourceStatusDesc{ get; set; }

        /// <summary>
        /// 订单类型为免费试用时的免费加固次数。
        /// </summary>
        [JsonProperty("TestTimes")]
        public long? TestTimes{ get; set; }

        /// <summary>
        /// 资源生效时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime{ get; set; }

        /// <summary>
        /// 资源过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 资源创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 订单审批人
        /// </summary>
        [JsonProperty("Approver")]
        public string Approver{ get; set; }

        /// <summary>
        /// 订单审批状态整型值
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// 订单审批状态整型值描述：0-未审批、1-审批通过、2-驳回。
        /// </summary>
        [JsonProperty("ApprovalStatusDesc")]
        public string ApprovalStatusDesc{ get; set; }

        /// <summary>
        /// 订单审批时间
        /// </summary>
        [JsonProperty("ApprovalTime")]
        public string ApprovalTime{ get; set; }

        /// <summary>
        /// 按次收费加固资源，其关联的总任务数
        /// </summary>
        [JsonProperty("TimesTaskTotalCount")]
        public long? TimesTaskTotalCount{ get; set; }

        /// <summary>
        /// 按次收费加固资源，其关联的任务成功数
        /// </summary>
        [JsonProperty("TimesTaskSuccessCount")]
        public long? TimesTaskSuccessCount{ get; set; }

        /// <summary>
        /// 按次收费加固资源，其关联的任务失败数
        /// </summary>
        [JsonProperty("TimesTaskFailCount")]
        public long? TimesTaskFailCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "PlatformTypeDesc", this.PlatformTypeDesc);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderTypeDesc", this.OrderTypeDesc);
            this.SetParamSimple(map, prefix + "AppPkgName", this.AppPkgName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "ResourceStatusDesc", this.ResourceStatusDesc);
            this.SetParamSimple(map, prefix + "TestTimes", this.TestTimes);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Approver", this.Approver);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "ApprovalStatusDesc", this.ApprovalStatusDesc);
            this.SetParamSimple(map, prefix + "ApprovalTime", this.ApprovalTime);
            this.SetParamSimple(map, prefix + "TimesTaskTotalCount", this.TimesTaskTotalCount);
            this.SetParamSimple(map, prefix + "TimesTaskSuccessCount", this.TimesTaskSuccessCount);
            this.SetParamSimple(map, prefix + "TimesTaskFailCount", this.TimesTaskFailCount);
        }
    }
}

