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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrderInfo : AbstractModel
    {
        
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }

        /// <summary>
        /// 订单要切换的套餐ID
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 订单类型
        /// <li>1 购买</li>
        /// <li>2 续费</li>
        /// <li>3 变配</li>
        /// </summary>
        [JsonProperty("TranType")]
        public string TranType{ get; set; }

        /// <summary>
        /// 订单状态。
        /// <li>1未支付</li>
        /// <li>2 支付中</li>
        /// <li>3 发货中</li>
        /// <li>4 发货成功</li>
        /// <li>5 发货失败</li>
        /// <li>6 已退款</li>
        /// <li>7 已取消</li>
        /// <li>100 已删除</li>
        /// </summary>
        [JsonProperty("TranStatus")]
        public string TranStatus{ get; set; }

        /// <summary>
        /// 订单更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 付费模式.
        /// <li>prepayment 预付费</li>
        /// <li>postpaid 后付费</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 订单绑定的扩展ID
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 资源初始化结果(仅当ExtensionId不为空时有效): successful(初始化成功), failed(初始化失败), doing(初始化进行中), init(准备初始化)
        /// </summary>
        [JsonProperty("ResourceReady")]
        public string ResourceReady{ get; set; }

        /// <summary>
        /// 安装标记。建议使用方统一转大小写之后再判断。
        /// <li>QuickStart：快速启动来源</li>
        /// <li>Activity：活动来源</li>
        /// </summary>
        [JsonProperty("Flag")]
        public string Flag{ get; set; }

        /// <summary>
        /// 下单时的参数
        /// </summary>
        [JsonProperty("ReqBody")]
        public string ReqBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "TranType", this.TranType);
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "ResourceReady", this.ResourceReady);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "ReqBody", this.ReqBody);
        }
    }
}

