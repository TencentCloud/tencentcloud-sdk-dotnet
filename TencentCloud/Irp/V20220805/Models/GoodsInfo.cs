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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GoodsInfo : AbstractModel
    {
        
        /// <summary>
        /// 商品唯一ID，skuId或spuId，客户根据需求自行决定商品主键粒度。建议限制在128字符以内
        /// </summary>
        [JsonProperty("GoodsId")]
        public string GoodsId{ get; set; }

        /// <summary>
        /// 商品物料展示类型：<br/>● article -图文<br>● text -纯文本<br/>● video -视频<br/>● short_video -时长15秒以内的视频<br/>● mini_video -竖屏视频<br/>● image -纯图片<br/>（如当前类型不满足，请<a href="https://console.cloud.tencent.com/workorder/category" target="_blank">提单</a>沟通解决方案）
        /// </summary>
        [JsonProperty("GoodsType")]
        public string GoodsType{ get; set; }

        /// <summary>
        /// 商品状态：
        /// ● 1 - 上架 
        /// ● 2 - 下架 
        /// Status=2的内容不会在推荐结果中出现 
        /// 需要下架内容时，把Status的值修改为2即可
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 商品生成时间，秒级时间戳（1639624786），需大于0，<b>用作特征和物料管理</b>
        /// </summary>
        [JsonProperty("PublishTimestamp")]
        public long? PublishTimestamp{ get; set; }

        /// <summary>
        /// 商品过期时间，秒级时间戳（1639624786），如未填，则默认PublishTimestamp往后延一年，<b>用作特征</b>，过期则不会被推荐，<b>强烈建议</b>
        /// </summary>
        [JsonProperty("ExpireTimestamp")]
        public long? ExpireTimestamp{ get; set; }

        /// <summary>
        /// spu((Standard Product Unit))维度id，商品聚合信息的最小单位，<b>强烈建议</b>
        /// </summary>
        [JsonProperty("SpuId")]
        public string SpuId{ get; set; }

        /// <summary>
        /// 类目层级数，例如3级类目，则填3，和CategoryPath字段的类数据匹配，<b>强烈建议</b>
        /// </summary>
        [JsonProperty("CategoryLevel")]
        public long? CategoryLevel{ get; set; }

        /// <summary>
        /// 类目路径，一级二级三级等依次用英文冒号联接，和CategoryLevel字段值匹配，如体育：“女装:裙子:半身裙”。<b>用于物料池管理，强烈建议</b>
        /// </summary>
        [JsonProperty("CategoryPath")]
        public string CategoryPath{ get; set; }

        /// <summary>
        /// 商品标题，<b>主要用于语义分析</b>，<b>强烈建议</b>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 商品标签，多个标签用英文冒号联接，<b>用作特征，强烈建议</b>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 商品对应的品牌，取值用户自定义，可以是品牌id或品牌明文，<b>用作特征以及打散/过滤规则，强烈建议</b>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 商品所属店铺ID，取值客户自定义，<b>用作特征，强烈建议</b>
        /// </summary>
        [JsonProperty("ShopId")]
        public string ShopId{ get; set; }

        /// <summary>
        /// 商品原始价格（单位：元，统一货币体系，如统一为RMB或美元等），<b>用作特征，强烈建议</b>
        /// </summary>
        [JsonProperty("OrgPrice")]
        public float? OrgPrice{ get; set; }

        /// <summary>
        /// 商品当前价格（单位：元，统一货币体系，如统一为RMB或美元等），<b>用作特征，强烈建议</b>
        /// </summary>
        [JsonProperty("CurPrice")]
        public float? CurPrice{ get; set; }

        /// <summary>
        /// 商品来源类型，客户自定义，<b>用于物料池管理</b>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 商品正文关键片段，建议控制在500字符以内，<b>主要用于语义分析</b>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 商品正文详情，主要用于语义分析，当内容过大时建议用ContentUrl传递，<b>与Content可二选一</b>
        /// </summary>
        [JsonProperty("ContentUrl")]
        public string ContentUrl{ get; set; }

        /// <summary>
        /// 商品封面url，不超过10个，<b>用作特征</b>
        /// </summary>
        [JsonProperty("PicUrlList")]
        public string[] PicUrlList{ get; set; }

        /// <summary>
        /// 卖家所在国家，ISO 3166-1 alpha-2编码，参考<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2" target="_blank">ISO 3166-1 alpha-2</a>，中国：“CN”，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 卖家所在省份，ISO 3166-2行政区编码，如中国参考<a href="https://zh.wikipedia.org/wiki/ISO_3166-2:CN" target="_blank">ISO_3166-2:CN</a>，广东省：“CN-GD”，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 卖家所在城市地区，统一用国家最新标准地区行政编码，如：<a href="https://www.mca.gov.cn/article/sj/xzqh/2020/" target="_blank">2020年行政区编码</a>，其他国家统一用国际公认城市简称或者城市编码，<b>用作特征</b>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 商品是否包邮；1:包邮；2:不包邮；3:满足条件包邮，<b>用作特征</b>
        /// </summary>
        [JsonProperty("FreeShipping")]
        public long? FreeShipping{ get; set; }

        /// <summary>
        /// 商品邮费（单位：元，统一货币体系，如统一为RMB或美元等），<b>用作特征</b>
        /// </summary>
        [JsonProperty("ShippingPrice")]
        public float? ShippingPrice{ get; set; }

        /// <summary>
        /// 商品累计好评次数，<b>用作特征</b>
        /// </summary>
        [JsonProperty("PraiseCnt")]
        public long? PraiseCnt{ get; set; }

        /// <summary>
        /// 商品累计评论次数，<b>用作特征</b>
        /// </summary>
        [JsonProperty("CommentCnt")]
        public long? CommentCnt{ get; set; }

        /// <summary>
        /// 商品累计分享次数，<b>用作特征</b>
        /// </summary>
        [JsonProperty("ShareCnt")]
        public long? ShareCnt{ get; set; }

        /// <summary>
        /// 商品累计收藏次数，<b>用作特征</b>
        /// </summary>
        [JsonProperty("CollectCnt")]
        public long? CollectCnt{ get; set; }

        /// <summary>
        /// 商品累积成交次数，<b>用作特征</b>
        /// </summary>
        [JsonProperty("OrderCnt")]
        public long? OrderCnt{ get; set; }

        /// <summary>
        /// 商品平均客户评分，取值范围用户自定，<b>用作特征</b>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// json字符串，<b>用于物料池管理的自定义扩展</b>
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsId", this.GoodsId);
            this.SetParamSimple(map, prefix + "GoodsType", this.GoodsType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PublishTimestamp", this.PublishTimestamp);
            this.SetParamSimple(map, prefix + "ExpireTimestamp", this.ExpireTimestamp);
            this.SetParamSimple(map, prefix + "SpuId", this.SpuId);
            this.SetParamSimple(map, prefix + "CategoryLevel", this.CategoryLevel);
            this.SetParamSimple(map, prefix + "CategoryPath", this.CategoryPath);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "OrgPrice", this.OrgPrice);
            this.SetParamSimple(map, prefix + "CurPrice", this.CurPrice);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ContentUrl", this.ContentUrl);
            this.SetParamArraySimple(map, prefix + "PicUrlList.", this.PicUrlList);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "FreeShipping", this.FreeShipping);
            this.SetParamSimple(map, prefix + "ShippingPrice", this.ShippingPrice);
            this.SetParamSimple(map, prefix + "PraiseCnt", this.PraiseCnt);
            this.SetParamSimple(map, prefix + "CommentCnt", this.CommentCnt);
            this.SetParamSimple(map, prefix + "ShareCnt", this.ShareCnt);
            this.SetParamSimple(map, prefix + "CollectCnt", this.CollectCnt);
            this.SetParamSimple(map, prefix + "OrderCnt", this.OrderCnt);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

